import sys
import customtkinter as ctk
from tkinter import messagebox
from PIL import Image
import os

ctk.set_appearance_mode("system")
ctk.set_default_color_theme("green")

class LoginUI:
    width = 900
    height = 600
    def __init__(self, admin_username, admin_password):
        self.admin_username = admin_username
        self.admin_password = admin_password
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
        self.username_entry = ctk.CTkEntry(master=frame, placeholder_text="Username")
        self.username_entry.pack(pady=12, padx=10)

        # Create a label and entry for the password
        self.password_entry = ctk.CTkEntry(master=frame, placeholder_text="Password", show="*")  # Hide the password
        self.password_entry.pack(pady=12, padx=10)

        # Create a login button
        self.login_button = ctk.CTkButton(master=frame, text="Login", command=self.login)
        self.login_button.pack(pady=12, padx=10)
        
        self.checkbox = ctk.CTkCheckBox(master=frame, text="Remember me")
        self.checkbox.pack(pady=12, padx=10)

    def login(self):
        entered_username = self.username_entry.get()
        entered_password = self.password_entry.get()

        if entered_username == self.admin_username and entered_password == self.admin_password:
            # Close the login window
            self.root.destroy()

            # Redirect to the main ticket UI
            from tickets.TicketTracker import TicketTracker
            tracker = TicketTracker('tickets.json')
            from tickets.TicketTrackerUI import TicketTrackerUI
            ui = TicketTrackerUI(tracker)  # Assuming 'tracker' is defined elsewhere
            ui.run()
        else:
            messagebox.showerror("Login Error", "Invalid username or password.")

    def run(self):
        self.root.mainloop()