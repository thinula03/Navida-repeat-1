# Project Approval System (PAS)

Premium ASP.NET Core MVC implementation for the PUSL2020 referral CILE brief.

## What is included

- Client-server welcome page for PAS.
- Server-side logging of identity details on page requests, searches, and form submissions.
- Geospatial department office display with simulated researcher coordinates.
- MVC Supervisor model, controller data flow, and Razor view rendering.
- SQLite database seeding with 7 mock supervisor records.
- Search by supervisor name or office location.
- Submit Proposal form with server-side Regex validation through Data Annotations.
- QA checklist section for the screenshot evidence required by the report.
- Responsive, executive-grade interface designed to look like an internal platform rather than a basic student demo.
- Clean project structure with models, services, persistence, controllers, Razor views, and static assets separated by responsibility.

## Before running

Edit `appsettings.json` and replace:

- `YOUR FULL NAME`
- `YOUR STUDENT ID`

The location is already set to `Colombo, Sri Lanka`.

## Run on the target device

Install .NET 8 SDK, then run:

```bash
dotnet restore
dotnet run
```

Open the URL shown in the console, usually:

```text
https://localhost:7224
```

The SQLite database file `pas-supervisors.db` is created automatically on first launch and seeded with mock supervisor records.

## Verification

The application has been checked with:

```bash
dotnet build --no-restore
```

Build status: success, 0 application errors.

Note: on the development Mac used for this handoff, NuGet printed a permission warning for the global vulnerability cache at `~/.local/share/NuGet`. That is an environment permission warning, not an application build error.

## Suggested screenshot evidence

- Home page showing the PAS welcome message and identity panel.
- Server console showing identity details after loading the page.
- Map section showing the department map and researcher coordinates.
- Supervisor table showing seeded database records.
- Search result for a matching supervisor or office.
- Search result with no matches.
- Invalid proposal form showing Regex validation errors.
- Valid proposal form showing the thank-you message.
- Code screenshot of `Models/ProposalSubmission.cs` showing the Regex attributes.
