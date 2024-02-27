import hashlib
import customtkinter as ctk
from tkinter import messagebox
from PIL import Image
import os

import requests

from .TicketAPI import TicketAPI

ctk.set_appearance_mode("system")
ctk.set_default_color_theme("green")


class LoginUI:
    width = 900
    height = 600

    def __init__(self):
        self.root = ctk.CTk()
        self.root.title("Login")
        self.root.geometry(f"{self.width}x{self.height}")
        self.root.resizable(False, False)
        current_path = os.path.dirname(os.path.realpath(__file__))
        self.bg_image = ctk.CTkImage(Image.open(current_path + "/test_images/bg_gradient.jpg"),
                                     size=(self.width, self.height))
        self.bg_image_label = ctk.CTkLabel(self.root, image=self.bg_image)
        self.bg_image_label.place(x=0, y=0, relwidth=1, relheight=1)

        frame = ctk.CTkFrame(master=self.root)
        frame.pack(pady=160, padx=280, fill="both", expand=True)

        label = ctk.CTkLabel(master=frame, text="Login System", font=("Arial", 24))
        label.pack(pady=12, padx=10)

        # Create a label and entry for the username
        self.username_entry = ctk.CTkEntry(master=frame, placeholder_text="Nombre de usuario")
        self.username_entry.pack(pady=12, padx=10)

        # Create a label and entry for the password
        self.password_entry = ctk.CTkEntry(master=frame, placeholder_text="Contraseña", show="*")  # Hide the password
        self.password_entry.pack(pady=12, padx=10)

        # Create a login button
        self.login_button = ctk.CTkButton(master=frame, text="Login", command=self.login)
        self.login_button.pack(pady=12, padx=10)

        # self.checkbox = ctk.CTkCheckBox(master=frame, text="Remember me")
        # self.checkbox.pack(pady=12, padx=10)

    def login(self):
        password_md5 = hashlib.md5(self.password_entry.get().encode()).hexdigest()

        # Make the API call
        response = requests.get('http://localhost:8089/api/perfiles')

        # Check if the request was successful
        if response.status_code != 200:
            print(f"Fallo al recibir los perfiles: {response.status_code}")
            return False

        # Check if the username and password match any of the profiles
        found = False
        for profile in response.json():
            if profile['dominio'] == self.username_entry.get() and profile['password'] == password_md5:
                found = True
                creator_id = profile['personal_id']
                print(f"Usuario {creator_id} ha iniciado sesión")
                ticket_api = TicketAPI()
                ticket_api.load_tickets_to_file(creator_id)
                # Close the login window
                self.root.destroy()

                # Redirect to the main ticket UI
                from .TicketTracker import TicketTracker
                tracker = TicketTracker('tickets.json')
                from .TicketTrackerUI import TicketTrackerUI
                ui = TicketTrackerUI(tracker, creator_id)  # Assuming 'tracker' is defined elsewhere
                ui.run()
                break

        if not found:
            messagebox.showerror("Error al acceder", "Usuario o contraseña incorrectos. Inténtelo de nuevo.")

        # No matching profile was found
        return False

    def run(self):
        self.root.mainloop()
