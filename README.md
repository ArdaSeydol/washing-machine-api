# Washing Machine API

This ASP.NET Core Web API project manages washing machines, their available programs, and customer purchases. It is developed using the Entity Framework Core Code First approach.

## Features
- Register washing machines and define available programs
- Manage program details (duration, temperature, pricing)
- Track customer purchases and ratings
- Link machines with program instances

## Database Structure (Code First)
- `WashingMachine`: machine serial and price
- `Program`: name, duration, temperature
- `AvailableProgram`: join table with price per machine
- `Customer`: basic customer info
- `PurchaseHistory`: records customer purchases

## Technologies Used
- ASP.NET Core (.NET 8)
- Entity Framework Core (Code First)
- SQL Server
- Swagger for API documentation

## Endpoints Overview
| Method | Endpoint                           | Description                       |
|--------|------------------------------------|-----------------------------------|
| GET    | `/api/machines`                    | Get list of machines              |
| GET    | `/api/customers/{id}`              | Get customer purchase history     |
| POST   | `/api/customers/{id}/purchase`     | Purchase a program                |
| DELETE | `/api/customers/{id}`              | Delete customer if no purchases  |

## Getting Started
1. Clone the repo
2. Run `dotnet ef migrations add Init`
3. Run `dotnet ef database update`
4. Start project: `dotnet run`
5. Access Swagger UI for testing

## Business Rules
- Customer cannot be deleted if they have any purchases
- Purchase date must be in the future
- PESEL (optional field) format must be valid
- Purchase must be linked to an existing program on a machine

## Future Enhancements
- Authentication (JWT)
- Program scheduling by time
- Admin dashboard to manage customers and machines
