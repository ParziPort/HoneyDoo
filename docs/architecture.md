# HoneyDoo architecture

HoneyDoo uses one deployable ASP.NET Core Razor Pages application targeting .NET 10. The solution also includes a separate integration-test project.

| Layer | Location | Starter scope |
| --- | --- | --- |
| Presentation | `Pages/`, `wwwroot/`, `Models/TeamInfo.cs` | Razor Pages render the welcome page and About page using a shared layout, local assets, and one source for team credit. |
| Business logic | `Services/` | Reserved for future rules such as assigning tasks and recording progress. |
| Data access | `Data/` | Reserved for SQLite persistence after the team reviews the data model and access approach. |

When the team implements task management, page models can call services for business rules, and services can use the data-access layer for persistence. Today the presentation layer renders static sample tasks and team information. App startup and the page tests require no SQLite database, schema, or migrations.
