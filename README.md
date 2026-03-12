# Expense Tracker API

A secure full-stack expense tracking application built with ASP.NET Core 8 and C#, 
featuring JWT authentication, Azure SQL database, and a clean frontend UI. 
Deployed on Microsoft Azure.

## 🌐 Live Demo
**Frontend:** https://saif-expense-tracker.azurewebsites.net/index.html
**API Docs:** https://saif-expense-tracker.azurewebsites.net/swagger/index.html

## 🛠 Tech Stack
- **Language:** C#
- **Framework:** ASP.NET Core 8
- **Database:** Azure SQL Server
- **ORM:** Entity Framework Core 8
- **Authentication:** JWT Bearer Tokens + ASP.NET Core Identity
- **Validation:** Data Annotations + Model State
- **Cloud:** Azure App Service + Azure SQL Database
- **Documentation:** Swagger UI

## 🔐 API Endpoints

### Auth (Public)
| Method | Endpoint | Description |
|--------|----------|-------------|
| POST | /api/auth/register | Register a new user |
| POST | /api/auth/login | Login and receive JWT token |

### Expenses (Protected 🔒)
| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | /api/expenses | Get all expenses |
| GET | /api/expenses/{id} | Get expense by ID |
| POST | /api/expenses | Create a new expense |
| DELETE | /api/expenses/{id} | Delete an expense |

## 🚀 How to Run Locally

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
4. Open frontend at `http://localhost:5078/index.html`
5. Open Swagger UI at `http://localhost:5078/swagger`

## 📋 Example Request

**POST /api/expenses** (requires Bearer token)
```json
{
  "title": "Grocery shopping",
  "amount": 2500,
  "category": "Food",
  "date": "2026-03-12"
}
```

## 👨‍💻 Developer
Muhammad Saif — CS Engineering Student, Óbuda University Budapest
