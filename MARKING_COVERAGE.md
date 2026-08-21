# PUSL2020 Marking Coverage Map

| Brief Section | Requirement | Implemented Evidence |
|---|---|---|
| Section 1 | Client-server interaction and welcome message | Home route `/`, welcome hero, controller request logging |
| Section 1 | Identity printed to server console | `StudentIdentityService.LogRequest()` used for home/search/submission/admin |
| Section 2 | Geospatial display | Premium map panel with department location and researcher coordinates |
| Section 2 | Identity visible with geospatial data | Identity card and visible location retained across the page |
| Section 3 | MVC architecture | `Supervisor` model, `HomeController`, Razor views, `HomeViewModel` |
| Section 3 | Mock supervisor list rendered | Seeded supervisors rendered in supervisor directory |
| Section 4 | Lightweight database | SQLite via EF Core, automatic database creation, seeded records |
| Section 4 | Search by Name or OfficeLocation | SQL-backed `EF.Functions.Like` search |
| Section 5 | Proposal/contact form | Submit Proposal form captures name, email, and abstract |
| Section 5 | Regex validation | `ProposalSubmission` Data Annotations with Regex rules |
| Additional | Premium dashboard | `/#dashboard` operational overview |
| Additional | Admin panel | `/Admin` dashboard for supervisor oversight and proposal review |
| Additional | Final report readiness | `FINAL_SUBMISSION_CHECKLIST.md`, `QA_TEST_CASES.md`, generated report draft |

