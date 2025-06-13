 Expense Tracker - ASP.NET Core MVC

A personal finance web application built with ASP.NET Core MVC to help users track daily spending with ease. This simple yet powerful tracker allows users to record, view, edit, delete, and filter expenses with a clean, responsive interface.

  Features

→ Add Expense → Record new spending (title, amount, category, date, notes).
→ View Expenses → See a complete list of expenses in a tabular format.
→ Edit Expense → Update existing records to correct or revise information.
→ Delete Expense → Permanently remove unwanted entries.
→ Filter Expenses → Search expenses by category or date range for better insights.

 🛠 Technologies Used

→ ASP.NET Core MVC  
→ Entity Framework Core  
→ SQL Server (LocalDB  
→ Razor Views + Bootstrap  
→ Git (Version Control)  
→ Azure App Service (Optional Deployment)

  Database Schema

Table: `Expenses`

| Field Name   | Type         | Description                    |
|--------------|--------------|--------------------------------|
| Id           | `int` (PK)   | Auto-increment primary key     |
| Title        | `string`     | Name/description of the expense|
| Amount       | `decimal`    | Expense amount                 |
| Category     | `string`     | Expense category               |
| ExpenseDate  | `DateTime`   | Date of expense                |
| Notes        | `string?`    | Optional notes                 |


 ⚙ Project Setup

 Step 1: Create Project

→ Open Visual Studio 2022 → Create a New Project  
→ Choose ASP.NET Core Web App (Model-View-Controller)  
→ Name it `Expense_Tracker` and click Create

 Step 2: Add Model

- Create `Expense.cs` in the Models folder  
- Add properties as per the schema above

 Step 3: Scaffold Controller & Views

- Right-click Controllers → Add → New Scaffolded Item  
- Choose: MVC Controller with views, using Entity Framework 
- Select:
  - Model Class: `Expense`
  - Data Context: `ApplicationDbContext`
  - Controller Name: `ExpensesController`

This generates all views and controller logic for CRUD operations.

 Step 4: Migrations

Open Package Manager Console :

```bash
Add-Migration InitialCreate
Update-Database

This creates and applies the initial database.

Step 5: Run the App
Press F5 or click Run. Use the navigation to:

Add Expense

View/Edit/Delete Expenses

Filter by category or date

📘 User Guide
➕ Add Expense
Click Add Expense

Enter title, amount, category, date, and optional notes

Click Add to save

 View Expenses
Lists all recorded expenses in a table

Each entry shows title, amount, category, date, and notes

 Edit Expense
Click Edit next to an entry

Modify values

Click Save to update

 Delete Expense
Click Delete next to an entry

Confirm deletion

Click Delete again

 Filter Expense
Use category textbox or date range fields (if implemented)

Click Filter

Click Reset or empty filters to view all again

 Deployment (Azure)
You can deploy to Azure App Service in just a few steps:

Right-click the project → Publish

Choose Azure App Service

Create/select a resource and hit Publish

Your app will be live on the web!

 License
This project is open-source and free to use for personal or educational purposes.

 Author
SANAPA THANOOJ PRAPULLA
Capstone Project – Personal Finance Web Application (2025)

