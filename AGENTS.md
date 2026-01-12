# Agents.md

- Code is in `src` folder
- Code is an ASP.NET Core web application (REST API with Swagger/OpenAPI)
- Project uses .NET 9.0 (specified in `src/Demolice.csproj`)

## Prerequisites
- Verify .NET 9.0 SDK is installed: `dotnet --info`
- Required packages: Azure.AI.OpenAI, Microsoft.EntityFrameworkCore.Sqlite

## Setup & build
- Install dependencies: `dotnet restore` (run from `src` folder)
- Rebuild: `dotnet build` (run from `src` folder)
- Run: `dotnet run --project src/Demolice.csproj` (from repository root) or `dotnet run` (from `src` folder)