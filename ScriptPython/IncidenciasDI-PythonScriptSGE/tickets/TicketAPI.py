import requests
import json


def _handle_response(response):
    if response.status_code != 200:
        print(f"Codigo de API: {response.status_code}")
        print(f"Texto de respuesta: {response.text}")
        raise Exception('API request failed')
    return response.json()


class TicketAPI:
    def __init__(self, api_url='http://localhost:8089'):
        self.api_url = api_url

    def get_ticket(self, creator_id):
        response = requests.get(f'{self.api_url}/api/incidencias/{creator_id}')
        return _handle_response(response)

    def load_tickets_to_file(self, creator_id):
        creator_id = int(creator_id)
        tickets = self.get_tickets(creator_id)
        with open('tickets.json', 'w') as f:
            json.dump(tickets, f)

    def get_tickets(self, creator_id):
        creator_id = int(creator_id)
        response = requests.get(f'{self.api_url}/api/incidencias/creadorId/{creator_id}')
        return _handle_response(response)

    def get_tickets_by_type(self, tipo):
        response = requests.get(f'{self.api_url}/api/incidencias/tipo={tipo}')
        return _handle_response(response)

    def get_tickets_by_state(self):
        response = requests.get(f'{self.api_url}/api/incidencias/estado')
        return _handle_response(response)

    def get_tickets_by_creator(self, creator_id):
        response = requests.get(f'{self.api_url}/api/incidencias/creadorId/{creator_id}')
        return _handle_response(response)

    def update_ticket(self, num, ticket_data):
        response = requests.put(f'{self.api_url}/api/incidencias/{num}', json=ticket_data)
        return _handle_response(response)

    def delete_ticket(self, num):
        response = requests.delete(f'{self.api_url}/api/incidencias/{num}')
        return _handle_response(response)

    def create_ticket(self, ticket_data):
        response = requests.post(f'{self.api_url}/api/incidencias', json=ticket_data)
        return _handle_response(response)
