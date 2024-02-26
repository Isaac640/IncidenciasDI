# ticket_tracker.py

import datetime
import json
from .Ticket import Ticket

class TicketTracker:
    def __init__(self, filename):
        self.filename = filename
        self.tickets = self.load_tickets()

    def load_tickets(self):
        with open(self.filename, 'r') as f:
            data = json.load(f)
        tickets = [Ticket.from_dict(ticket_data) for ticket_data in data]
        for i, ticket in enumerate(tickets):
            ticket.local_id = (i+1)
        return tickets

    def save_tickets(self):
        with open(self.filename, 'w') as f:
            json.dump([ticket.to_dict() for ticket in self.tickets], f, indent=4)

    def add_ticket(self, ticket):
        # Set the fecha_creacion to the current time
        ticket.start_time = datetime.datetime.now().timestamp()
        self.tickets.append(ticket)
        self.save_tickets()

    def delete_ticket(self, local_id):
        index_to_delete = None
        for i, ticket in enumerate(self.tickets):
            if ticket.local_id == local_id:
                index_to_delete = i
                break
        if index_to_delete is not None:
            del self.tickets[index_to_delete]
            # Update the local_id for the tickets that come after the deleted one
            for j in range(index_to_delete, len(self.tickets)):
                self.tickets[j].local_id = (j+1)
            self.save_tickets()
        
    def export_tickets(self, filename):
        with open(filename, 'w') as f:
            json.dump([ticket.to_dict() for ticket in self.tickets], f, indent=4)

    def get_ticket(self, local_id):
        for ticket in self.tickets:
            if ticket.local_id == local_id:
                return ticket
        return None
