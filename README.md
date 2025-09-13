# LIMS-WebApp

Repository: LIMS-WebApp — a simple Laboratory Information Management System (LIMS) implemented with ASP.NET Core (.NET 8), MediatR, Autofac, EF Core and a layered architecture (WebAPI, Application, Domain, Infrastructure).

## Projects
- LIMS.WebAPI: ASP.NET Core Web API exposing endpoints and hosting configuration (Swagger enabled in Development).
- LIMS.Application: Application layer with commands, queries, handlers, and mapping profiles (MediatR handlers).
- LIMS.Domain: Domain models and repository interfaces.
- LIMS.Infrastructure: EF Core DbContext, repository implementations, migrations and a bundled SQLite DB for quick local runs.

## Requirements
- .NET 8 SDK
- Optional: SQL Server LocalDB (project contains a LocalDB connection string) or use the included SQLite DB.

## Configuration
Configuration is in `LIMS.WebAPI/appsettings.json`.
Default connection strings:
- DefaultConnection (SQLite): `Data Source=..\\LIMS.Infrastructure\\Database\\SQLiteDB\\LIMS.db`
- LocalDBConnection (MSSQL LocalDB): `Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LIMS_db;Integrated Security=True;...`

To switch between SQLite and LocalDB, update `LIMS.WebAPI/Program.cs` where the DbContext is configured.

## Build and run
From repository root:

- Build: `dotnet build LIMS.WebApp.sln`
- Run the API: `dotnet run --project LIMS.WebAPI` (by default runs with HTTPS)

When running in Development environment, Swagger UI is available (Program.cs enables UseSwagger and UseSwaggerUI for Development).

## API Endpoints (summary)
Base path: controllers are conventional; actions use explicit routes as shown below.

- InstrumentController
  - GET  /GetAllInstruments
  - GET  /GetInstrument/{id}
  - POST /CreateInstrument
  - POST /UpdateInstrument
  - DELETE /DeleteInstrument/{id}

- LaboratoryController
  - GET  /GetAllLaboratories
  - GET  /GetLaboratory/{id}
  - POST /CreateLab
  - POST /UpdateLab
  - DELETE /DeleteLab?id={id}

- OrderDetailsController
  - GET  /GetAllOrderDetails
  - POST /CreateOrderDetails

- TechnicianController
  - GET  /GetAllTechnicians
  - GET  /{id}
  - POST /CreateTechnician
  - POST /UpdateTechnician
  - DELETE /DeleteTechnician (expects parameters as model)

Note: Some controllers use custom routes or default controller routing. Check `LIMS.WebAPI/Controllers` for exact signatures.

## Database
- EF Core migrations are in `LIMS.Infrastructure/Migrations`.
- A SQLite DB (`LIMS.db`) is included under `LIMS.Infrastructure/Database/SQLiteDB` for convenience.

## Development notes
- Uses Autofac for DI container (registered in `Program.cs` via ApplicationModule).
- Uses MediatR for CQRS-style commands/queries.
- Mapping configured in `LIMS.Application.Mappers` via AutoMapper profiles.

## Tests
No test projects were detected in the solution root. If you add tests, document how to run them here.

## Contributing
- Fork the repository, create a branch, and open a pull request with a descriptive title and description.

## License
Add a license file if you intend to open-source this repository.

---
Generated README: basic overview and usage instructions. For deeper documentation (ER diagrams, sequence flows, DTO schemas), add docs/ or extend this file.
