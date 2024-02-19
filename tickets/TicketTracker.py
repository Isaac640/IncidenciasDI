# ticket_tracker.py

import json
from .Ticket import Ticket

class TicketTracker:
    def __init__(self, filename):
        self.filename = filename
        self.tickets = self.load_tickets()

    def load_tickets(self):
        try:
            with open(self.filename, 'r') as f:
                data = json.load(f)
            return [Ticket.from_dict(ticket_data) for ticket_data in data]
        except FileNotFoundError:
            return []

    def save_tickets(self):
        with open(self.filename, 'w') as f:
            json.dump([ticket.to_dict() for ticket in self.tickets], f, indent=4)

    def add_ticket(self, description):
        id = len(self.tickets) +   1
        self.tickets.append(Ticket(id, description))
        self.save_tickets()

    def delete_ticket(self, id):
        index_to_delete = None
        for i, ticket in enumerate(self.tickets):
            if ticket.id == id:
                index_to_delete = i
                break
        if index_to_delete is not None:
            del self.tickets[index_to_delete]
            for i, ticket in enumerate(self.tickets):
                ticket.id = i +  1
            self.save_tickets()
        
    def export_tickets(self, filename):
        with open(filename, 'w') as f:
            json.dump([ticket.to_dict() for ticket in self.tickets], f, indent=4)

    def get_ticket(self, id):
        for ticket in self.tickets:
            if ticket.id == id:
                return ticket
        return None
