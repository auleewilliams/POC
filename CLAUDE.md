# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Overview

This is a proof-of-concept repository containing three independent .NET Core 3.0 C# projects. Each project lives in its own directory with its own `.sln` and `.csproj` files.

## Build & Run Commands

```bash
# Build a specific project
dotnet build ToDoApi/ToDoApi.sln
dotnet build Stripe-API-Integration/Stripe-API-Integration.sln
dotnet build TestingStringFunctions/TestingStringFunctions.sln

# Run a specific project
dotnet run --project ToDoApi
dotnet run --project Stripe-API-Integration
dotnet run --project TestingStringFunctions/TestingStringFunctions
```

There are no automated tests or lint tooling configured in this repository.

## Projects

### ToDoApi

ASP.NET Core 3.0 REST API following MVC pattern with Entity Framework Core.

- **Models** (`Models/`): `TodoItem` (Id, Name, IsComplete) and `TodoContext` (EF DbContext)
- **Controllers** (`Controllers/`): `TodoItemsController` exposes full CRUD at `/api/TodoItems`; `WeatherForecastController` is a scaffolded demo endpoint
- **Database**: SQL Server, configured in `Startup.cs` with connection string pointing to `localhost`, database `TodoList`, using Windows Trusted Connection

Data flow: `HTTP Request → Controller → TodoContext (EF Core) → SQL Server`

### Stripe-API-Integration

Console app demonstrating the Stripe.net (v33.7.0) library. Retrieves charges, payouts, and balance transactions. API keys and IDs are placeholder empty strings — real credentials are required to run.

### TestingStringFunctions

Console app exploring string manipulation. Core logic in `ReturnTransformedSources()`: removes underscores from strings, then truncates to 5 characters (e.g., `"MPBJ_WEB"` → `"MPBJW"`).
