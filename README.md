# HoneyDoo

**One home. One list. Less stress.**

HoneyDoo is a household task-management project for Purdue Global IT488 Software Product Development Using Agile, Group 3. Fourward Solutions consists of Cris Brown-Renteria, Jacob Lasley, Christopher Lawrence, and Matt Newport.

The starter includes a responsive welcome page, a static example of household tasks, an About page, and shared team credit. Household accounts, shared household spaces, task assignment and due dates, progress tracking, and SQLite persistence are planned for future iterations. The current pages run without a database.

## Prerequisites

- The .NET 10 SDK. Check the installed SDKs with `dotnet --list-sdks`.
- Visual Studio with .NET 10 support and the **ASP.NET and web development** workload, or an editor that supports C# and the .NET 10 SDK.
- Git for source control and collaboration.

## Run from the workspace root

```powershell
dotnet restore HoneyDoo.sln
dotnet build HoneyDoo.sln --no-restore
dotnet test HoneyDoo.sln --no-build
dotnet run --project src/HoneyDoo.Web/HoneyDoo.Web.csproj --launch-profile http
```

The HTTP profile uses `http://localhost:5188`. For the URL actually used, check the console line beginning with `Now listening on:` or inspect `applicationUrl` in `src/HoneyDoo.Web/Properties/launchSettings.json`. Stop the command-line server with **Ctrl+C**.

For local HTTPS, trust the ASP.NET Core development certificate with `dotnet dev-certs https --trust` and select the `https` launch profile. Its configured HTTPS URL is `https://localhost:7188`. The HTTP profile needs no certificate.

## Run in Visual Studio

1. Open `HoneyDoo.sln` and let Visual Studio restore the NuGet packages.
2. If needed, right-click **HoneyDoo.Web** in Solution Explorer and select **Set as Startup Project**.
3. Select the **http** profile in the Run dropdown. Press **F5** to debug or **Ctrl+F5** to run without debugging.
4. Open **About** from the header. To run the smoke tests, open **Test > Test Explorer** and select **Run All Tests**.

## Project map

| Path | Purpose |
| --- | --- |
| `src/HoneyDoo.Web/Pages/` | Welcome and About page copy. Edit the shared header and footer markup in `Shared/_Layout.cshtml`. |
| `src/HoneyDoo.Web/Models/TeamInfo.cs` | Team name, member names, and course credit shared by both pages. |
| `src/HoneyDoo.Web/wwwroot/` | Local assets. Edit colors in `css/site.css`, the logo in `images/honeydoo-mark.svg`, and the tab icon in `favicon.svg`. |
| `src/HoneyDoo.Web/Services/` and `Data/` | Reserved for business rules and SQLite data access. |
| `tests/HoneyDoo.Web.Tests/` | Integration smoke tests for the two Razor Pages and shared footer. |
| `docs/` | [Architecture](docs/architecture.md) and [Unit 1 environment checklist](docs/unit1-environment-checklist.md). |

GitHub stores the source code and collaboration history. The ASP.NET Core application runs locally with the .NET SDK or on a separately configured host. Keep credentials, development certificates, and real household data out of source control.
