import requests
import json

class TicketAPI:
    def __init__(self, api_url='http://localhost:8089'):
        self.api_url = api_url

    def get_ticket(self, id):
        response = requests.get(f'{self.api_url}/api/incidencias/{id}')
        return self._handle_response(response)

    def load_tickets_to_file(self): 
        tickets = self.get_tickets()
        with open('tickets.json', 'w') as f:
            json.dump(tickets, f)

    def get_tickets(self):
        response = requests.get(f'{self.api_url}/api/incidencias')
        return self._handle_response(response)

    def get_tickets_by_type(self, tipo):
        response = requests.get(f'{self.api_url}/api/incidencias/tipo={tipo}')
        return self._handle_response(response)

    def get_tickets_by_state(self):
        response = requests.get(f'{self.api_url}/api/incidencias/estado')
        return self._handle_response(response)

    def get_tickets_by_creator(self, id):
        response = requests.get(f'{self.api_url}/api/incidencias/creadorId/{id}')
        return self._handle_response(response)

    def update_ticket(self, id, ticket_data):
        response = requests.put(f'{self.api_url}/api/incidencias/{id}', json=ticket_data)
        return self._handle_response(response)

    def delete_ticket(self, id):
        response = requests.delete(f'{self.api_url}/api/incidencias/{id}')
        return self._handle_response(response)

    def create_ticket(self, ticket_data):
        response = requests.post(f'{self.api_url}/api/incidencias', json=ticket_data)
        return self._handle_response(response)

    def _handle_response(self, response):
        if response.status_code in [200, 201]:
            return response.json()
        else:
            raise Exception('API request failed')