Problem Statement:
Create a personal finance web app to record and manage daily expenses. Users can add, view, edit, and delete expenses with a clean, minimal interface.

Project Setup Steps:
1.	Open Visual Studio 2022.
2.	Select  “Create a New Project”.
3.	Choose the Template as “ASP.NET Core Web App (Model-View-Controller)” and Click “Next”.
4.	Name the Project as “Expense_Tracker” 
5.	Create an Expense.cs class in the Model Folder.
6.	Create an Entity Framework Controller →Pass the ExpensesModel → Add the Context → Select SQL Server → Click “Next”.
7.	Right-click on Controllers folder →Add→New Scaffolded Item
➔	Choose: “MVC Controller with views, using Entity Framework” and Name the Controller as “Expenses”
➔	Model Class: Expense.cs
➔	Data Context Class: ApplicationDbContext
8.	Go to Tools → NuGet Packager Manager → Open Package Manager Console → Execute these 2 commands:-
➔	Add-Migration InitialCreate
➔	Update-Database
9.	Open SQL Object Explorer → SQL Server → MS SQL Localdb → Database → ExpenseTracker_Context → Tables → dbo.Expense → Right click → View Data.

