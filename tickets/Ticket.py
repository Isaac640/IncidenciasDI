import time
from datetime import datetime

def seconds_to_hms(seconds):
    """Convert seconds to hours, minutes, and seconds."""
    hours, remainder = divmod(seconds,  3600)
    minutes, seconds = divmod(remainder,  60)
    return "{:02}:{:02}:{:02}".format(int(hours), int(minutes), int(seconds))

class Ticket:
    def __init__(self, id, description):
        self.id = id
        self.description = description
        self.status = 'not-started'
        self.start_time = None
        self.end_time = None
        self.total_time =  0.0
        self.current_session_start = None

    def start(self):
        if self.status == 'not-started':
            self.status = 'started'
            self.current_session_start = time.time()  # Set the start of the current session
            self.start_time = time.time()  # Set the start time of the ticket

    def resume(self):
        if self.status == 'paused':
            self.status = 'started'
            self.current_session_start = time.time()  # Set the start of the current session

    def pause(self):
        if self.status == 'started':
            self.status = 'paused'
            self.current_session_start = None  # Reset the start of the current session

    def finish(self):
        if self.status == 'started' or self.status == 'paused':
            self.status = 'finished'
            self.current_session_start = None
            self.end_time = time.time()  # Set the end time of the ticket

    def to_dict(self):
        return {
            'id': self.id,
            'description': self.description,
            'status': self.status,
            'start_time': datetime.fromtimestamp(self.start_time).strftime('%d/%m/%Y %H:%M:%S') if self.start_time else None,
            'end_time': datetime.fromtimestamp(self.end_time).strftime('%d/%m/%Y %H:%M:%S') if self.end_time else None,
            'total_time': seconds_to_hms(self.total_time)
        }

    @classmethod
    def from_dict(cls, data):
        ticket = cls(data['id'], data['description'])
        ticket.status = data['status']
        ticket.start_time = cls.parse_time(data['start_time'])
        ticket.end_time = cls.parse_time(data['end_time'])
        ticket.total_time = cls.time_string_to_seconds(data['total_time'])
        return ticket

    @staticmethod
    def parse_time(time_str):
        if time_str:
            return datetime.strptime(time_str, '%d/%m/%Y %H:%M:%S').timestamp()
        return None

    @staticmethod
    def time_string_to_seconds(time_str):
        if time_str:
            hours, minutes, seconds = map(int, time_str.split(':'))
            return hours *  3600 + minutes *  60 + seconds
        return  0.0