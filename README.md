# _Pierre's Bakery Vendor Tracker_

#### _ASP.NET Core MVC Independent Project for Epicodus_, _Mar. 13, 2020_

#### By _**Michelle Morin**_

## Description

_This project (accessible on [Github](https://github.com/michelle-morin/Bakery.Solution)) is an MVC web application for Pierre's Bakery, to help Pierre keep track of vendors that purchase baked goods from him and the orders belonging to those vendors. The homepage of the application is a splash page welcoming Pierre and providing him with a link to a vendors page. The vendors page contains a link to a page presenting Pierre with a form he can fill out to create a new Vendor. After the form is submitted, the new vendor object is saved in a static list of vendors and Pierre is routed back to the homepage. Pierre can also click a vendor's name to route to a page that displays all of that vendor's orders, or click a link to creare a new order for a particular vendor._ 

## Specifications:

| Specification | Example Input | Example Output |
| ------------- |:-------------:| -------------:|
| Application creates an instance of an order object having properties for the title, description, price, and date of the order | form submitted with title, description, price, and date fields completed | new order object created |
| Application creates an instance of a vendor object having properties for vendor name, description of vendor, and a list of orders belonging to the vendor | form submitted with vendor name and description fields completed | new vendor object created |
| Each new vendor is added to a static list of vendors | new vendor object created | static list of vendors now incldues newly added vendor |

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

_Run this console application by entering the following commands in Terminal (macOS) or PowerShell (Windows):_
* ``cd Bakery``
* ``dotnet run``

## Technologies Used
* _Git_
* _C#_
* _ASP.NET Core MVC_
* _dotnet script_

### License

*This webpage is licensed under the MIT license.*

Copyright (c) 2020 **_Michelle Morin_**