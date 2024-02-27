from datetime import datetime, timedelta
from tkinter import simpledialog
import customtkinter as ctk
import tkinter as tk
from tkinter import filedialog, messagebox
from threading import Thread, Event

import requests

from tickets.Ticket import Ticket, seconds_to_hms
from tickets.TicketAPI import TicketAPI
from .TicketTracker import TicketTracker
import time
# ticket_tracker_ui.py

ctk.set_appearance_mode("system")
ctk.set_default_color_theme("dark-blue")


class TicketTrackerUI:
    
    def __init__(self, tracker, creator_id):
        print("Creator id en init de TicketTrackerUI")
        
        creator_id = creator_id
        print(creator_id)
        self.tracker = tracker
        self.root = ctk.CTk()
        self.root.title("Ticket Tracker")
        self.root.geometry("700x460")
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
            if(ticket.status == 'en proceso'):
                ticket.status = 'pausada'
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
        self.add_button = ctk.CTkButton(master=frame, text="Crear Incidencia", command=lambda: self.add_ticket(creator_id))
        self.add_button.pack(padx=5, pady=5)

        self.start_button = ctk.CTkButton(master=frame, text="Iniciar incidencia", command=self.start_ticket)
        self.start_button.pack(padx=5, pady=5)

        self.pause_button = ctk.CTkButton(master=frame, text="Pausar incidencia", command=self.pause_ticket)
        self.pause_button.pack(padx=5, pady=5)

        self.resume_button = ctk.CTkButton(master=frame, text="Resumir Incidencia", command=self.resume_ticket)
        self.resume_button.pack(padx=5, pady=5)

        self.finish_button = ctk.CTkButton(master=frame, text="Finalizar Incidencia", command=self.finish_ticket)
        self.finish_button.pack(padx=5, pady=5)

        self.delete_button = ctk.CTkButton(master=frame, text="Borrar Incidencia", command=self.delete_ticket)
        self.delete_button.pack(padx=5, pady=5)

        self.change_responsible_button = ctk.CTkButton(master=frame, text="Cambiar Responsable", command=self.change_responsible)
        self.change_responsible_button.pack(padx=5, pady=5)

        self.update_button = ctk.CTkButton(master=frame, text="Actualizar BBDD", command=lambda: self.update_tickets_to_API(creator_id))
        self.update_button.pack(padx=5, pady=5)

        self.updateTickets_button = ctk.CTkButton(master=frame, text="Actualizar Incidencias", command=lambda: self.updateTickets(creator_id))
        self.updateTickets_button.pack(padx=5, pady=5)

        self.export_button = ctk.CTkButton(master=frame, text="Exportar Incidencias", command=self.export_tickets)
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
            print(ticket)
            if ticket:
                ticket.resume()
                ticket.current_session_start = time.time()  # Record the start of the current session
                self.tracker.save_tickets()
                self.update_ticket_list()

    def update_time_elapsed(self, stop_event):
        while not stop_event.is_set():
            # Update the time elapsed for each ticket
            for ticket in self.tracker.tickets:
                if ticket.status == 'en proceso':
                    if ticket.total_time is None:
                        ticket.total_time = 0
                    else:
                        ticket.total_time += 1
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
            if elapsed_time is not None:
                elapsed_time_str = str(timedelta(seconds=int(elapsed_time)))  # Remove the microseconds
            else:
                elapsed_time_str = "00:00:00"  # Remove the microseconds

        # Add the ticket information and elapsed time to the listbox
            self.ticket_listbox.insert(tk.END, f"{ticket.id}: {ticket.description} ({ticket.status}, {elapsed_time_str} en proceso)")

    # Reselect the previously selected item, if any
        if current_selection:
            self.ticket_listbox.select_set(current_selection[0])

    # Restore the scrollbar position
        self.ticket_listbox.yview_moveto(scrollbar_position[0])

    def add_ticket(self, creator_id):
    # Ask the user for the ticket information
        tipo = simpledialog.askstring("New Ticket", "Introduce el tipo (EQUIPOS, CUENTAS, WIFI, INTERNET, SOFTWARE):")
        subtipo_id = simpledialog.askinteger("New Ticket", "Introduce el subtipo del ID:")
        descripcion = simpledialog.askstring("New Ticket", "Introduce la descripcion:")

    # Check if the user entered all the information
        if tipo is None or subtipo_id is None or descripcion is None:
            messagebox.showerror("Error", "Debes introducir toda la informacion.")
            return

    # Get the last ticket's num and add 1 to it
        if self.tracker.tickets:
            id = self.tracker.tickets[-1].id + 1
        else:
            id = 1

    # Create the new ticket
        ticket = Ticket(id=id, tipo=tipo, subtipo_id=subtipo_id, descripcion=descripcion, creator_id=creator_id, tiempo="00:00:00")

    # Add the ticket to the tracker
        self.tracker.add_ticket(ticket)

    # Update the ticket list
        self.update_ticket_list()

    def delete_ticket(self):
        selected_id = self.ticket_listbox.curselection()
        if selected_id:
            ticket = self.tracker.get_ticket(selected_id[0] +  1)
            # Make a GET request to the API to check if the ticket already exists
            response = requests.get(f'http://localhost:8089/api/incidencias/{ticket.id}')

            if response.status_code == 200:
                print(f"Ticket {ticket.id} exists in database, deleting it...")
                # The ticket already exists, so delete it
                response = requests.delete(f'http://localhost:8089/api/incidencias/{ticket.id}')
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
            for ticket in self.tracker.tickets:
                if ticket.status == 'en proceso':
                    ticket.status = 'pausada'
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
            ticket.responsable_id = new_responsible_id

        # Update the ticket in the tracker
            self.tracker.tickets[ticket_index] = ticket

        # Save the tickets
            self.tracker.save_tickets()

    # Update the listbox
        self.update_ticket_list()

    def updateTickets(self, creator_id):
    # Create an instance of TicketAPI
        api = TicketAPI()

    # Get the tickets from the API
        tickets_data = api.get_tickets(creator_id)

    # Convert the ticket data to Ticket objects
        tickets = [Ticket.from_dict(ticket_data) for ticket_data in tickets_data]

    # Change the status of the tickets that are "en proceso" to "pausada"
        for ticket in tickets:
            if ticket.status == "en proceso":
                ticket.status = "pausada"

    # Save the tickets to the file
        self.tracker.tickets = tickets
        self.tracker.save_tickets()

    # Update the listbox
        self.update_ticket_list()

    def update_tickets_to_API(self, creator_id):
    # Ask the user if they are sure they want to upload the information
        if not messagebox.askyesno("Confirm", "Are you sure you want to upload the information?"):
            return  # The user is not sure, so don't upload the information

    # Loop through all the tickets
        for ticket in self.tracker.tickets:
        # Convert the ticket to a dictionary
            ticket_data = ticket.to_dict()

        # Convert the date to the correct format
            date_str = ticket_data["fecha_creacion"]  # Replace "date" with the actual key for the date
            date_obj = datetime.strptime(date_str, "%d/%m/%Y %H:%M:%S")
            ticket_data["fecha_creacion"] = date_obj.strftime("%Y-%m-%dT%H:%M:%S.%f")
            date_str = ticket_data["fecha_cierre"]  # Replace "date" with the actual key for the date
            if date_str is not None:
                date_obj = datetime.strptime(date_str, "%d/%m/%Y %H:%M:%S")
                ticket_data["fecha_cierre"] = date_obj.strftime("%Y-%m-%dT%H:%M:%S.%f")

            # Make a GET request to the API to check if the ticket already exists
            response = requests.get(f'http://localhost:8089/api/incidencias/{ticket.id}')

            if response.status_code == 200:
                print(f"Ticket {ticket.id} already exists, updating it...")
                # The ticket already exists, so update it
                print(ticket_data)
                response = requests.put(f'http://localhost:8089/api/incidencias/{ticket.id}', json=ticket_data)
                print(response.status_code)
            else:
                print(f"Ticket {ticket.id} doesn't exist, creating it...")
                # The ticket doesn't exist, so create a new one
                print(ticket_data)
                response = requests.post('http://localhost:8089/api/incidencias', json=ticket_data)

        # Check if the request was successful
            if response.status_code not in (200, 201):
                print(f"Failed to update ticket: {response.status_code}")
                return

        # Update the tickets
        self.updateTickets(creator_id)

    def run(self):
        self.root.mainloop()
