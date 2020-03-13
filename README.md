# _Pierre's Bakery Vendor Tracker_

#### _ASP.NET Core MVC Independent Project for Epicodus_, _Mar. 13, 2020_

#### By _**Michelle Morin**_

## Description

_This project (accessible on [Github](https://github.com/michelle-morin/Bakery.Solution)) is an ASP.NET Core MVC web application for Pierre's Bakery. The application helps Pierre track vendors that purchase baked goods from Pierre's Bakery, as well as the order(s) belonging to each vendor. The homepage of the application includes a link to view a list of all vendors. The vendors page contains an "add vendor" URL, whink links to a form for adding a new Vendor to the vendors list. After submitting the form, the application forms a new vendor object and returns to the list of vendors. Each vendor's name is clickable to route to a page listing all orders for that vendor. Each order listed is clickable to route to a page listing order details, as well as the option to edit or delete the order. On a detail page for a particular vendor, an "add order" button routes to a form for creating a new order object and a "delete vendor" button deletes the vendor and all associated orders from Pierre's Bakery Vender Tracker._ 

## Specifications:

| Specification | Example Input | Example Output |
| ------------- |:-------------:| -------------:|
| Application creates an instance of an order object having properties for the title, description, price, date of the order, invoice status (paid/unpaid), and a unique ID | form submitted with title, description, price, invoice status, and date fields completed | new order object created |
| Each new order has unique Id | new order object created | Id property of order object is 1 greater than prior order object's Id |
| Each new order is added to static list of orders | new order object created | static list of all orders now includes order object |
| Application creates an instance of a vendor object having properties for vendor name, description of vendor, a list of orders belonging to the vendor, and a unique ID | form submitted with vendor name and description fields completed | new vendor object created |
| Each new vendor is added to a static list of vendors | new vendor object created | static list of vendors now incldues newly added vendor |
| Application routes to error view when order details or vendor details are input as null or whitespace | user submits new order form with null or whitespace inputs | Error view displays "invalid input" |
| Application allows user to delete specific orders | user selects delete order button | order is removed from static list of all orders, as well as from the parent Vendor object's Orders list |
| Application allows user to edit details for a specific order | user clicks "edit order" button | webpage routes to form for editing properties of the order object |
| Application allows user to delete a specific vendor from the vendors list | user clicks "delete vendor" button | vendor is removed from static list of vendors and all orders corresponding to the deleted vendor are deleted from static list of orders |

## Setup/Installation Requirements

### Install .NET Core

#### on macOS:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a .NET Core SDK from Microsoft Corp._
* _Open the file (this will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.)_

#### on Windows:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp._
* _Open the .exe file and follow the steps provided by the installer for your OS._

#### Install dotnet script
_Enter the command ``dotnet tool install -g dotnet-script`` in Terminal (macOS) or PowerShell (Windows)._

### Clone this repository

_Enter the following commands in Terminal (macOS) or PowerShell (Windows):_
* ``cd desktop``
* ``git clone https://github.com/michelle-morin/Bakery.Solution``
* ``cd Bakery.Solution``

_Confirm that you have navigated to the Bakery.Solution directory (e.g., by entering the command_ ``pwd`` _in Terminal)._

_To view/edit the source code of this application, open the contents of the Bakery.Solution directory in a text editor or IDE of your choice (e.g., to open all contents of the directory in Visual Studio Code on macOS, enter the command_ ``code .`` _in Terminal)._

_Run this application by entering the following commands in Terminal (macOS) or PowerShell (Windows):_
* ``cd Bakery``
* ``dotnet restore``
* ``dotnet build``
* ``dotnet run`` or ``dotnet watch run``

## Technologies Used
* _Git_
* _C#_
* _ASP.NET Core MVC_
* _dotnet script_
* _Bootstrap_
* _CSS_

### License

*This webpage is licensed under the MIT license.*

Copyright (c) 2020 **_Michelle Morin_**