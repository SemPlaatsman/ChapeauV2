# ChapeauV2
A C# WinForms project for a restaurant ordering system with a SQL database.

## Functionalities
- Login, Register, and Change password system (by using question and answer.
- Overview of all tables with colored occupation status.
- History of current and delivered orders, and assigned Employee per table.
- Add orders per table from list of items (divided into sections).
- Option to pay bill with partial payment using cash, PIN, or creditcard. 
- Receipt is generated with calculated taxes after payment.
- Bar and kitchen displays for the bartender and chef, respectively, with all orders of today.

## My contributions
- Bar and kitchen display (combined functionality)
  - Display divided into: to be made, currently being made, and an overview of all orders.
  - All orders in the overview are color coded to the status of the order (to be made = orange/red, being made = yellow, done = green).
  - Each order in the overview is clickable and when clicked, shows a popup with duration since order, dish, type (starter, main course, dessert, drink, intermediate course), status (can be changed per item or entire order), and serving status.
  - Added functionality to push late orders. If an item is added to an order that is currently being made, the status of the item is automatically changed to being made so that those items will not be forgotten.
  - Added 30 second refresh timer and refresh button to refresh all orders.
- Exception handling
  - Custom Exception called ChapeauException which is used for expected errors such unfilled field, invalid input format, et cetera.
  - ErrorLogger class for logging unexpected errors with date and time of error, message, and stack trace, which are logged to a file called errorLogs.txt in the root of the project.
- Hashing
  - PasswordService class (inspired by [this](https://dotnetcodr.com/2016/10/17/how-to-hash-passwords-with-a-salt-in-net/)) for hashing and verifying passwords which uses a salt from the app.config file (and generates and saves one when it doesn't exist).
