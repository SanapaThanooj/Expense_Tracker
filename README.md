Capstone Project: Expense Tracker (MVC)
 Project Overview
 Create a personal finance web app to record and manage daily expenses. Users can add,
 view, edit, and delete expenses with a clean, minimal interface.
 Table of Contents
 1. Features
 Add a new expense
 View all expenses
 Edit an expense
 Delete an expense
 Filter expenses by category or date range
 2. Technologies Used
 ASP.NET Core MVC
 Entity Framework Core
 SQL Server
 Razor Views + Bootstrap
 Azure App Service (Deployment)
 Git for version control

 4. Controller
 DateTime
 string (opt)
 ExpensesController.cs
 Handles all operations:
 Index() – List all expenses
 Create() – Add new expense
 Edit(id) – Modify expense
 Details(id) – View details
 Delete(id) – Delete expense
 (Optional: Add filtering logic inside 
Index() )
5. Views
 Views/expenses/ 
├── Index.cshtml 
├── Create.cshtml 
├── Edit.cshtml 
├── Details.cshtml 
└── Delete.cshtml
 6. Folder Structure
 expenseTracker/ 
├── Controllers/ 
│   
└── expensesController.cs 
├── Models/ 
│   
└── expense.cs 
├── Views/ 
│   
└── expenses/ 
├── Data/ 
│   
└── ETContext.cs
 7. Deployment
 Push code to GitHub
 Publish to Azure App Service
 Use Azure SQL Database
 Configure 
8. Documentation
 appsettings.json for DB connection
 Setup steps
 User manual (how to add/edit/delete/filter expenses)
 Screenshots or demo video
 Code comment
