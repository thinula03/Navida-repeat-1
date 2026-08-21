# PAS QA Test Cases

Use these test cases in the final report. Replace screenshot references with your actual captured images.

| ID | Area | Test Scenario | Steps | Expected Result | Evidence |
|---|---|---|---|---|---|
| TC-01 | Client-server | Home page loads PAS welcome message | Run the app and open `/` | Browser displays "Welcome to the Project Approval System (PAS)!" | Home page screenshot |
| TC-02 | Server logging | Identity logs on page request | Open `/` and observe terminal | Console includes full name, student ID, and Colombo, Sri Lanka | Terminal screenshot |
| TC-03 | Dashboard | Dashboard presents operational summary | Open `/#dashboard` | Supervisor count, persistence, validation, and audit status are visible | Dashboard screenshot |
| TC-04 | Geospatial | Map and coordinates display | Open `/#map` | Department map, department coordinates, and researcher coordinates are visible | Map screenshot |
| TC-05 | MVC rendering | Supervisor data renders through MVC | Open `/#supervisors` | Supervisor table displays seeded records from controller/view model | Supervisor table screenshot |
| TC-06 | Search success | Search finds matching supervisor office/name | Search for `Computing` | Matching supervisors are returned | Successful search screenshot |
| TC-07 | Search empty | Search handles no results | Search for `zzzz-not-found` | Empty-state message is displayed | No result screenshot |
| TC-08 | Regex invalid name | Invalid student name is rejected | Submit name with numbers, valid email, abstract | Name validation error is displayed | Validation screenshot |
| TC-09 | Regex invalid email | Invalid email is rejected | Submit valid name, invalid email, abstract | Email validation error is displayed | Validation screenshot |
| TC-10 | Valid proposal | Valid proposal is accepted | Submit valid name, email, and abstract | Thank-you message is displayed and proposal is saved | Success screenshot |
| TC-11 | Admin review | Admin panel shows submitted proposal | Open `/Admin` after valid submission | Proposal appears in proposal intake review | Admin screenshot |
| TC-12 | Admin logging | Admin request logs identity | Open `/Admin` and observe terminal | Console logs identity details for admin request | Terminal screenshot |

