import datetime
from tkinter import simpledialog
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

        self.scrollbar = tk.Scrollbar(master=frame)
        
        self.ticket_listbox = tk.Listbox(master=frame, yscrollcommand=self.scrollbar.set, bg='black', fg='white')

        # Configure the scrollbar to scroll the listbox
        self.scrollbar.config(command=self.ticket_listbox.yview)

        # Pack (or grid) the scrollbar and the listbox
        self.scrollbar.pack(side=tk.LEFT, fill=tk.Y)
        self.ticket_listbox.pack(side=tk.LEFT, fill=tk.BOTH, expand=True)
        
        #self.ticket_listbox = tk.Listbox(master=frame, width=100, height=10)
        #self.ticket_listbox.pack()

        for ticket in tracker.tickets:
            self.ticket_listbox.insert(tk.END, f"{ticket.id}: {ticket.description} ({ticket.status})")

        # Create the listbox and associate it with the scrollbar
        


            
        self.selected_index = tk.IntVar(value=-1)
        
        #self.ticket_listbox.bind('<<ListboxSelect>>', self.on_select)

        # Function to update the selected index when the selection changes
        def on_select(self, event):
        # Get the current selection
            selection = self.ticket_listbox.curselection()

        # Check if an item is selected
            if selection:
            # Set the selected index
                self.selected_index.set(selection[0])
            else:
            # No item is selected, set the selected index to -1
                self.selected_index.set(-1)

        # Use customtkinter's CTkEntry for the description entry
        self.description_entry = ctk.CTkEntry(master=frame)
        self.description_entry.pack(padx=5, pady=5)

        # Use customtkinter's CTkButton for the buttons
        self.add_button = ctk.CTkButton(master=frame, text="Add Ticket", command=self.add_ticket)
        self.add_button.pack(padx=5, pady=5)

        self.delete_button = ctk.CTkButton(master=frame, text="Delete Ticket", command=self.delete_ticket)
        self.delete_button.pack(padx=5, pady=5)

        self.start_button = ctk.CTkButton(master=frame, text="Start Ticket", command=self.start_ticket)
        self.start_button.pack(padx=5, pady=5)

        self.pause_button = ctk.CTkButton(master=frame, text="Pause Ticket", command=self.pause_ticket)
        self.pause_button.pack(padx=5, pady=5)

        self.resume_button = ctk.CTkButton(master=frame, text="Resume Ticket", command=self.resume_ticket)
        self.resume_button.pack(padx=5, pady=5)

        self.finish_button = ctk.CTkButton(master=frame, text="Finish Ticket", command=self.finish_ticket)
        self.finish_button.pack(padx=5, pady=5)
        
        self.change_responsible_button = ctk.CTkButton(master=frame, text="Cambiar Responsable", command=self.change_responsible)
        self.change_responsible_button.pack(padx=5, pady=5)

        self.export_button = ctk.CTkButton(master=frame, text="Export Tickets", command=self.export_tickets)
        self.export_button.pack(padx=5, pady=5)

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
    # Store the currently selected index and scrollbar position
        current_selection = self.ticket_listbox.curselection()
        scrollbar_position = self.ticket_listbox.yview()

    # Get the number of items in the listbox
        num_items = self.ticket_listbox.size()

    # Delete all items
        if num_items > 0:
            self.ticket_listbox.delete(0, num_items - 1)

    # Populate the listbox with the ticket information
        for ticket in self.tracker.tickets:
        # Calculate the elapsed time
            elapsed_time = ticket.total_time
        # Format the elapsed time as a string
            elapsed_time_str = str(elapsed_time).split('.')[0]  # Remove the microseconds

        # Add the ticket information and elapsed time to the listbox
            self.ticket_listbox.insert(tk.END, f"{ticket.id}: {ticket.description} ({ticket.status}, {elapsed_time_str} elapsed)")

    # Reselect the previously selected item, if any
        if current_selection:
            self.ticket_listbox.select_set(current_selection[0])

    # Restore the scrollbar position
        self.ticket_listbox.yview_moveto(scrollbar_position[0])

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
            
    def change_responsible(self):
        # Get the currently selected ticket
        current_selection = self.ticket_listbox.curselection()
        if not current_selection:
            return  # No ticket is selected

        ticket_index = current_selection[0]
        ticket = self.tracker.tickets[ticket_index]

        # Ask the user for the new responsible person's ID
        new_responsible_id = simpledialog.askstring("Change Responsible", "Enter the new responsible person's ID:")
        if new_responsible_id is not None:
            # Update the responsible person
            ticket.responsible_id = new_responsible_id

            # Update the listbox
            self.update_ticket_list()

    def run(self):
        self.root.mainloop()
