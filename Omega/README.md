# Restaurant Management System
- Restaurant Management system is built based on C# WinsForm connected with MSSQL database.
- Final school project of final-year student aka "Omega".

## Author
- Name: Huong Quynh Tran
- Email: huongquynhtran182003@gmail.com
- School: Secondary Technical School of Electrical Engineering
- Grade: C4b

## Technology used
- C# .NET
- MSSQL
- System.Security.Cryptography (hashing password)

## Table of Contents
- [Installation](#installation)
- [Run](#run)
- [Configuration](#configuration)
- [Use Case](#use-case)
- [Architecture](#architecture)
  - [User tier](#user-tier)
  - [Business tier](#business-tier)
  - [Data tier](#data-tier)
- [E-R diagram](#e-r-diagram)
- [File structure](#file-structure)
- [Errors](#errors)
- [Licence](#licence)
- [Resume](#resume)


## Installation
```bash
git clone https://github.com/QuynhTran182003/Omega.git
```

## Run 
Windows CMD and Git Bash

```bash
cd Omega/Omega/bin/Debug/

./Omega.exe # execute exe file, or you can just click on it.
```

## Configuration

User has access to configure following variables at `Omega/App.config`
- **localConnection** - local connection to database.
- **connectionKantnerova** - remote connection to database, do not change it.
- **skolniConnection** connectionString="Data Source=**PCXXX**;Initial Catalog=Alpha_Three;Persist Security Info=True;User ID=**sa**;Password=**student**"  
Connection string to the database. Uses sa user, **You have to change PCXXX to your PC**.


## Use Case
Default user is created in database: **Login**=admin1, **Password**=admin1, role of the user is Administrator
- As administrator you can:
    - See all employees
    - Create employee
    - All allowed actions to cashier (as below)

- As cashier you can:
    - CRUD operator for Category (name, DPH) 
    - CRUD operator for Product (name, code, price, category)
    - Create order and add order details
    - Print bill (when customer pays)
    - See overview all bills, daily reports


## Architecture
Project is developed as three-tier application.  
Main functionality is provided by Presentation Tier (Interactive Forms), Business Tier (Objects) and Data Tier(Data Access Objects).

Design patterns: 
- DatabaseConnection is Singleton

### Presentation tier
- Provided by .NET WinForms. Main forms are LoginForm and MainForm.

### Business tier
- IBaseClass - interface that makes sure every object has an UNIQUE id.
- access the Data Access Object.

### Data tier
- IDAO: interface with 4 essential operators CRUD (CREATE, READ, UPDATE, DELETE)
- Directly communicates with database, more functionalities than CRUD in case of need (eg. get list of all orders etc.).

## E-R diagram
![ER diagram](/img/ER Diagram.png "Diagram")

## File structure
<pre>
```
📦 Omega
├─ Omega
│  ├─ Business Tier
│  │  ├─ Bill.cs
│  │  ├─ BillItem.cs
│  │  ├─ Category.cs
│  │  ├─ Item.cs
│  │  ├─ Order.cs
│  │  ├─ Product.cs
│  │  ├─ Table.cs
│  │  └─ User.cs
│  ├─ Database Singleton
│  │  └─ DatabaseSingleton.cs
│  ├─ Data Tier
│  │  ├─ BillDAO.cs
│  │  ├─ CategoryDAO.cs
│  │  ├─ CreateDatabase.cs
│  │  ├─ ItemDAO.cs
│  │  ├─ OrderDAO.cs
│  │  ├─ ProductDAO.cs
│  │  ├─ TableDAO.cs
│  │  └─ UserDAO.cs
│  ├─ Presentation Tier
│  │  ├─ Panels
│  │  │  ├─ CategoryPanel.Designer.cs
│  │  │  ├─ CategoryPanel.cs
│  │  │  ├─ CategoryPanel.resx
│  │  │  ├─ ListBillPanel.Designer.cs
│  │  │  ├─ ListBillPanel.cs
│  │  │  ├─ ListBillPanel.resx 
│  │  │  ├─ ProductPanel.Designer.cs
│  │  │  ├─ ProductPanel.cs
│  │  │  ├─ ProductPanel.resx 
│  │  │  ├─ ReportPanel.Designer.cs
│  │  │  ├─ ReportPanel.cs 
│  │  │  ├─ ReportPanel.resx 
│  │  │  ├─ ZamestnanecPanel.Designer.cs
│  │  │  ├─ ZamestnanecPanel.cs 
│  │  │  ├─ ZamestnanecPanel.resx
│  │  ├─ UserControls
│  │  │  ├─ BillItemUC.Designer.cs
│  │  │  ├─ BillItemUC.cs 
│  │  │  ├─ BillItemUC.resx 
│  │  │  ├─ ItemUC.Designer.cs
│  │  │  ├─ ItemUC.cs
│  │  │  └─ ItemUC.resx
│  │  ├─ BillForm.Designer.cs
│  │  ├─ BillForm.cs
│  │  ├─ BillForm.resx
│  │  ├─ EditItemForm.Designer.cs
│  │  ├─ EditItemForm.cs
│  │  ├─ EditItemForm.resx
│  │  ├─ LoginForm.Designer.cs
│  │  ├─ LoginForm.cs
│  │  ├─ LoginForm.resx
│  │  ├─ MainForm.Designer.cs
│  │  ├─ MainForm.Designer2.cs
│  │  ├─ MainForm.Designer3.Designer.cs
│  │  ├─ MainForm.Designer3.cs
│  │  ├─ MainForm.Initializer.cs
│  │  ├─ MainForm.cs
│  │  ├─ MainForm.resx
│  │  ├─ NewUserForm.Designer.cs
│  │  ├─ NewUserForm.cs
│  │  ├─ NewUserForm.resx
│  │  ├─ PaymentForm.Designer.cs
│  │  ├─ PaymentForm.cs 
│  │  └─ PaymentForm.resx
│  ├─ Interfaces
│  │  ├─ IBaseClass.cs
│  │  └─ IDAO.cs
│  ├─ Properties
│  │  ├─ AssemblyInfo.cs 
│  │  ├─ Resources.Designer.cs 
│  │  ├─ Resources.resx 
│  │  ├─ Settings.Designer.cs
│  │  └─ Settings.settings
│  ├─ Resources
│  │  ├─ logo.png
│  │  └─ shiba.png
│  ├─ sql script
│  │  └─ SQLQuery1.sql
│  ├─ vendor
│  │  └─ Hashing.cs
│  ├─ App.con
│  ├─ Omega.csproj
│  ├─ Program.cs
│  ├─ packages.config
│  └─ README.md
├─ .gitattributes
├─ .gitignore
└─ Omega.sln
```
</pre>

## Errors
- Application handles SqlExceptions which notifies user error, meanwhile application can continue execution.

## Licence
MIT License

Copyright (c) 2024 Huong Quynh Tran

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

## Resume
This project was developed as school task in order to teach students how to work on bigger solutions.  
That definitely gonna teach students to think in advance and try to design better and inteligent projects.  
This project can be used as educational content in schools.  