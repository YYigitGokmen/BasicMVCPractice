# BasicMVCPractice
Patika+ Fullstack Bootcamp BasicMVCPractice

![BasivMVCSS](https://github.com/user-attachments/assets/31ce88d7-3166-4456-89d9-ebb5d8ae7f54)


MVC Project
Task: View Customer and Order Information
By following the steps below, we are developing an application to display customer and order information using ASP.NET MVC.

Stage 1: Model Creation
Customer Model:

Create a Customer class.

Id (Customer's unique ID, type int)

FirstName (Customer's name, in string type)

LastName (Customer's last name, in string type)

Email (Customer's email address, in string type)

Order Model:

Create an Order class.

Id (Unique ID of the order, type int)

ProductName (The name of the product, in string type)

Price (The price of the product, in decimal type)

Quantity (Amount of product ordered, in int type)

Stage 2: Creating ViewModel
CustomerOrderViewModel Class:

Create a CustomerOrderViewModel class.

Customer (A Customer object)

Orders (A list of Order objects)

ViewModel will hold together the model data and any additional information needed to display it in the view.

Stage 3: Creating a Controller
CustomerOrdersController:

Create a CustomerOrdersController class.

In this controller, create an action method called Index.

In the index method:

Create a sample Customer object and several Order objects.

Create a CustomerOrderViewModel object using these objects.

Pass the CustomerOrderViewModel object to the view.

Stage 4: Creating View
Index View:

Create a view named Index.cshtml under the Views/CustomerOrders folder.

This view will show customer information and orders using CustomerOrderViewModel.

In View:

View customer information (ID, name, surname, email).

Create a table of orders and list order ID, product name, price and quantity.

