import time
from datetime import datetime

def seconds_to_hms(seconds):
    """Convert seconds to hours, minutes, and seconds."""
    hours, remainder = divmod(seconds,  3600)
    minutes, seconds = divmod(remainder,  60)
    return "{:02}:{:02}:{:02}".format(int(hours), int(minutes), int(seconds))

class Ticket:
    def __init__(self, id, description):
        self.local_id = None
        self.id = id
        self.description = description
        self.status = 'abierta'
        self.start_time = None
        self.end_time = None
        self.total_time =  0.0
        self.current_session_start = None
        self.responsable_id = None

    def start(self):
        print(self.status)
        if self.status == 'abierta':
            self.status = 'en proceso'
            self.current_session_start = time.time()  # Set the start of the current session
            self.start_time = time.time()  # Set the start time of the ticket

    def resume(self):
        print(self.status)
        if self.status == 'pausada':
            self.status = 'en proceso'
            self.current_session_start = time.time()  # Set the start of the current session

    def pause(self):
        print(self.status)
        if self.status == 'en proceso':
            self.status = 'pausada'
            self.current_session_start = None  # Reset the start of the current session

    def finish(self):
        print(self.status)
        if self.status == 'en proceso' or self.status == 'pausada':
            self.status = 'resuelta'
            self.current_session_start = None
            self.end_time = time.time()  # Set the end time of the ticket

    def to_dict(self):
        return {
            'num': self.id,
            'descripcion': self.description,
            'estado': self.status,
            'fecha_creacion': datetime.fromtimestamp(self.start_time).strftime('%d/%m/%Y %H:%M:%S') if self.start_time else None,
            'fecha_cierre': datetime.fromtimestamp(self.end_time).strftime('%d/%m/%Y %H:%M:%S') if self.end_time else None,
            'tiempo': seconds_to_hms(self.total_time),
            'responsable_id': self.responsable_id
        }

    @classmethod
    def from_dict(cls, data):
        ticket = cls(data['num'], data['descripcion'])
        ticket.status = data['estado']
        ticket.start_time = cls.parse_time(data['fecha_creacion'])
        ticket.end_time = cls.parse_time(data['fecha_cierre'])
        ticket.total_time = cls.time_string_to_seconds(data['tiempo'])
        ticket.responsable_id = data['responsable_id']
        return ticket

    @staticmethod
    def parse_time(time_str):
        if time_str:
            return datetime.strptime(time_str, '%Y-%m-%d').timestamp()
        return None

    @staticmethod
    def time_string_to_seconds(time_str):
        if time_str:
            hours, minutes, seconds = map(int, time_str.split(':'))
            return hours *  3600 + minutes *  60 + seconds
        return  0.0