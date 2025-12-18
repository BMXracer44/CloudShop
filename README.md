#Cloud Shop

A .NET and C# Program used to help me learn and develop .NET and C# programming skills 

##The Core 

Strong Typing & Records: Using record types for immutable Data Transfer Objects (DTOs). 
LINQ: Writing complex queries to filter and transform data 
Generics: Building reusable repositories and wrappers 
Async/Await: Understanding the Task parallel library to ensure our server doesn't block under load 

##The API Layer (ASP.NET Core)
RESTful services using:
Middleware: Creating custom logic for global error handling and logging 
Dependency Injection (DI): The backbone of .NET. How to manage service lifetimes (Transient, Scoped, Singleton)
Filters & Validation: Using FluentValidation to keep our controllers clean. 

##The Data Layer (Entity Framework Core)
To connect to an SQL database:
Code-First Migrations: Versioning a database schema 
Relationships: One-to-many and many-to-many mappings 
Performance: Eager vs. Lazy loading and using AsNoTracking() for read-only queries 

##The Architecture Breakdown 
Web API - ASP.NET Core 8/9 - Interface for frontend/mobile clients 
Identity - Microsoft Entra / JWT - Securing the app with token-based authentication 
Database - SQL Server + EF Core - Persistent storage for orders/products 
Caching - Redis - High-speed storage for frequently accessed catalog data 
Background Tasks - Hangfire or Worker Services - Processing emails or clearing old carts in the background 
