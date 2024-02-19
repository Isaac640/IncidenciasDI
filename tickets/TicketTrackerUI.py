import customtkinter as ctk
import tkinter as tk
from tkinter import filedialog, messagebox
from threading import Thread, Event

from tickets.Ticket import seconds_to_hms
from .TicketTracker import TicketTracker
import time
# ticket_tracker_ui.py

ctk.set_appearance_mode("system")
ctk.set_default_color_theme("dark-blue")


class TicketTrackerUI:
    def __init__(self, tracker):
        self.tracker = tracker
        self.root = ctk.CTk()
        self.root.title("Ticket Tracker")
        self.root.geometry("500x350")
        self.root.resizable(False, False)
        
        frame = ctk.CTkFrame(master=self.root)
        frame.pack(pady=20, padx=60, fill="both", expand=True)

        # Use customtkinter's CTkLabel for the listbox label
        self.ticket_listbox_label = ctk.CTkLabel(master=frame, text="Tickets:")
        self.ticket_listbox_label.pack()

        # Use customtkinter's CTkTextbox as a listbox
        self.ticket_listbox = ctk.CTkTextbox(master=frame, width=100, height=10, state='disabled')  # Adjust the width and height as needed
        self.ticket_listbox.pack()

        # Variable to store the index of the selected item
        self.selected_index = tk.IntVar()

        # Function to update the selected index when the selection changes
        def on_select(event):
            self.selected_index.set(self.ticket_listbox.index(tk.SEL_FIRST))

        # Bind the function to the <<ListboxSelect>> event
        self.ticket_listbox.bind('<<ListboxSelect>>', on_select)

        # Use customtkinter's CTkEntry for the description entry
        self.description_entry = ctk.CTkEntry(master=frame)
        self.description_entry.pack()

        # Use customtkinter's CTkButton for the buttons
        self.add_button = ctk.CTkButton(master=frame, text="Add Ticket", command=self.add_ticket)
        self.add_button.pack()

        self.delete_button = ctk.CTkButton(master=frame, text="Delete Ticket", command=self.delete_ticket)
        self.delete_button.pack()

        self.start_button = ctk.CTkButton(master=frame, text="Start Ticket", command=self.start_ticket)
        self.start_button.pack()

        self.pause_button = ctk.CTkButton(master=frame, text="Pause Ticket", command=self.pause_ticket)
        self.pause_button.pack()

        self.resume_button = ctk.CTkButton(master=frame, text="Resume Ticket", command=self.resume_ticket)
        self.resume_button.pack()

        self.finish_button = ctk.CTkButton(master=frame, text="Finish Ticket", command=self.finish_ticket)
        self.finish_button.pack()

        self.export_button = ctk.CTkButton(master=frame, text="Export Tickets", command=self.export_tickets)
        self.export_button.pack()

        self.update_ticket_list()
        
        self.stop_event = Event()
        self.update_thread = Thread(target=self.update_time_elapsed, args=(self.stop_event,))
        self.update_thread.daemon = True
        self.update_thread.start()
        
    def start_ticket(self):
        selected_id = self.ticket_listbox.curselection()
        if selected_id:
            ticket = self.tracker.get_ticket(selected_id[0] +  1)
            if ticket:
                ticket.start()
                ticket.current_session_start = time.time()  # Record the start of the current session
                self.tracker.save_tickets()
                self.update_ticket_list()

    def resume_ticket(self):
        selected_id = self.ticket_listbox.curselection()
        if selected_id:
            ticket = self.tracker.get_ticket(selected_id[0] +  1)
            if ticket:
                ticket.resume()
                ticket.current_session_start = time.time()  # Record the start of the current session
                self.tracker.save_tickets()
                self.update_ticket_list()

    def update_time_elapsed(self, stop_event):
        while not stop_event.is_set():
            # Update the time elapsed for each ticket
            for ticket in self.tracker.tickets:
                if ticket.status == 'started':
                    elapsed_time = time.time() - ticket.current_session_start  # Calculate elapsed time for the current session
                    ticket.total_time += elapsed_time
                    ticket.current_session_start = time.time()  # Reset the start of the current session for the next update
            # Schedule the UI update on the main thread
            self.root.after(1000, self.update_ticket_list)
            # Wait for a second before the next update
            stop_event.wait(1)

    def update_ticket_list(self):
        # Clear the textbox
        self.ticket_listbox.delete('1.0', tk.END)

        # Populate the textbox with the updated ticket information
        for index, ticket in enumerate(self.tracker.tickets):
            elapsed_time = ticket.total_time
            self.ticket_listbox.insert(tk.END, f"{ticket.id}: {ticket.description} ({ticket.status}, {seconds_to_hms(elapsed_time)})")

        # Restore the selection
        if self.selected_index.get() != -1:
            self.ticket_listbox.tag_add(tk.SEL, f"{self.selected_index.get() +  1}.0", f"{self.selected_index.get() +  1}.end")

    def add_ticket(self):
        description = self.description_entry.get()
        if description:
            self.tracker.add_ticket(description)
            self.description_entry.delete(0, tk.END)
            self.update_ticket_list()

    def delete_ticket(self):
        selected_id = self.ticket_listbox.curselection()
        if selected_id:
            self.tracker.delete_ticket(selected_id[0] +   1)
            self.update_ticket_list()

    def start_ticket(self):
        selected_id = self.ticket_listbox.curselection()
        if selected_id:
            ticket = self.tracker.get_ticket(selected_id[0] +   1)
            if ticket:
                ticket.start()
                self.tracker.save_tickets()
                self.update_ticket_list()

    def pause_ticket(self):
        selected_id = self.ticket_listbox.curselection()
        if selected_id:
            ticket = self.tracker.get_ticket(selected_id[0] +   1)
            if ticket:
                ticket.pause()
                self.tracker.save_tickets()
                self.update_ticket_list()

    def resume_ticket(self):
        selected_id = self.ticket_listbox.curselection()
        if selected_id:
            ticket = self.tracker.get_ticket(selected_id[0] +   1)
            if ticket:
                ticket.resume()
                self.tracker.save_tickets()
                self.update_ticket_list()

    def finish_ticket(self):
        selected_id = self.ticket_listbox.curselection()
        if selected_id:
            ticket = self.tracker.get_ticket(selected_id[0] +   1)
            if ticket:
                ticket.finish()
                self.tracker.save_tickets()
                self.update_ticket_list()
                
    def export_tickets(self):
        filename = filedialog.asksaveasfilename(defaultextension=".json", filetypes=[("JSON files", "*.json")])
        if filename:
            self.tracker.export_tickets(filename)
            messagebox.showinfo("Export Successful", f"Tickets exported to {filename}")

    def run(self):
        self.root.mainloop()
