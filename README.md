# Expense Tracker API

A RESTful API built with ASP.NET Core 8 and C#, deployed on Microsoft Azure.

## Live URL
https://saif-expense-tracker.azurewebsites.net/swagger

## Tech Stack
- **Language:** C#
- **Framework:** ASP.NET Core 8
- **Database:** SQLite (local) 
- **ORM:** Entity Framework Core 8
- **Cloud:** Azure App Service
- **Documentation:** Swagger UI

## API Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | /api/expenses | Get all expenses |
| POST | /api/expenses | Create a new expense |
| DELETE | /api/expenses/{id} | Delete an expense by ID |

## How to Run Locally

1. Clone the repository
```bash
git clone https://github.com/muhammadsaif9008/expense-tracker-api.git
```
2. Navigate to project folder
```bash
cd ExpenseTrackerAPI
```
3. Run the application
```bash
dotnet run
```
4. Open Swagger UI at `http://localhost:5078/swagger`

## Example Request

**POST /api/expenses**
```json
{
  "title": "Grocery shopping",
  "amount": 2500,
  "category": "Food",
  "date": "2026-03-09"
}
```

## Developer
Muhammad Saif — CS Engineering Student, Óbuda University Budapest
