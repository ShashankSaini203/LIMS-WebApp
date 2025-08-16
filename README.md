# LIMS-WebApp

Repository: LIMS-WebApp — a simple Laboratory Information Management System (LIMS) implemented with ASP.NET Core (.NET 8), MediatR, Autofac, EF Core and a layered architecture (WebAPI, Application, Domain, Infrastructure).

## Projects
- LIMS.WebAPI: ASP.NET Core Web API exposing endpoints and hosting configuration (Swagger enabled in Development).
- LIMS.Application: Application layer with commands, queries, handlers, and mapping profiles (MediatR handlers).
- LIMS.Domain: Domain models and repository interfaces.
- LIMS.Infrastructure: EF Core DbContext, repository implementations, migrations and a bundled SQLite DB for quick local runs.
