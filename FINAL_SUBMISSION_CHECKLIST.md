# PAS Final Submission Checklist

Use this checklist before creating the final documentation report PDF.

## Required Identity Setup

Update `appsettings.json`:

```json
"FullName": "YOUR REAL FULL NAME",
"StudentId": "YOUR REAL STUDENT ID",
"LiveLocation": "Colombo, Sri Lanka"
```

## Run Commands

```powershell
dotnet restore
dotnet build
dotnet dev-certs https --trust
dotnet run
```

Open:

```text
https://localhost:7224
```

Admin panel:

```text
https://localhost:7224/Admin
```

## Screenshot Evidence To Capture

1. Home page welcome message with identity panel visible.
2. Server console after loading the page, showing full name, student ID, and Colombo, Sri Lanka.
3. Premium dashboard section at `/#dashboard`.
4. Geospatial map section with department and researcher coordinates.
5. Supervisor directory showing seeded records.
6. Supervisor search with a successful result.
7. Supervisor search with no results.
8. Invalid proposal submission showing Regex validation errors.
9. Valid proposal submission showing the thank-you message.
10. Admin panel at `/Admin` showing proposal intake review.
11. Code screenshot of `Models/ProposalSubmission.cs` showing Regex attributes.
12. Code screenshot of `Controllers/HomeController.cs` showing MVC controller logic.

## Top-Grade Talking Points

- ASP.NET Core MVC architecture with separate Models, Views, Controllers, Services, and Data layers.
- SQLite persistence with automatic database creation and seeded supervisor data.
- Server-side Regex validation using Data Annotations.
- Server-side identity logging on home, search, proposal submission, and admin requests.
- Premium responsive UI with dashboard, map visualization, supervisor search, proposal form, and admin panel.
- Admin panel provides operational oversight and evidence for submitted proposals.
