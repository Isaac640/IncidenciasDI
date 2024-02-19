from tickets.LoginUI import LoginUI

# Define the admin username and password
admin_username = "admin"
admin_password = "password"

# Create and run the login interface
login_ui = LoginUI(admin_username, admin_password)
login_ui.run()
