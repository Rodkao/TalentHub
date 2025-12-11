# TalentHub API 

A streamlined, robust Backend API designed to demonstrate **Clean Architecture** and **Modern .NET practices** applied to a Recruitment Management context.

> **Project Goal:** To showcase structural quality, maintainability, and SOLID principles over feature complexity. This project serves as a technical proof-of-concept for a scalable Junior Developer codebase.

## Architecture & Design Decisions

This solution implements **Clean Architecture**, separating concerns into distinct layers to ensure the core business logic remains independent of external frameworks.

* **TalentHub.Domain:** Contains the Enterprise Logic and Entities.
* **TalentHub.Application:** Defines the Use Cases and Interfaces (Repository Pattern).
* **TalentHub.Infrastructure:** Implements data access using **Entity Framework Core** and **SQL Server**.
* **TalentHub.API:** A thin presentation layer using **RESTful endpoints**.

## Tech Stack

* **Framework:** .NET 10 (C# 14) - *Leveraging latest features like Primary Constructors.*
* **Database:** SQL Server.
* **ORM:** Entity Framework Core (Code-First approach).
* **Testing:** xUnit (Unit Testing for Domain Logic).
* **Documentation:** Swagger / OpenAPI.

## Key Features Implemented

* **Robust CRUD Operations:** Full management of Job Offers.
* **Business Logic Validation:** Strict validation rules ensuring data integrity at the Domain level.
* **Dependency Injection:** Fully decoupled services configured in `Program.cs`.
* **Automated Documentation:** Interactive API testing via Swagger UI.

## How to Run

1.  Clone this repository.
2.  Open the solution `TalentHub.sln` in **Visual Studio**.
3.  Ensure you have **SQL Server LocalDB** (default with VS) or update the `ConnectionStrings` in `appsettings.json`.
4.  Run the database migrations in the Package Manager Console:
    ```powershell
    Update-Database
    ```
5.  Press **F5** to run. The browser should open with Swagger.
    > **Note:** If it doesn't open automatically, navigate to: `http://localhost:<PORT>/swagger/index.html` (check the console output to see your specific port, e.g., 5094).
