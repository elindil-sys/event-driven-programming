# Students MVC Demo (Group 1)

Minimal ASP.NET Core MVC app to demonstrate the request flow for:

    GET /Students/Details/7

## Run

```bash
dotnet run
```

Then open: http://localhost:5000/Students/Details/7
(or the port shown in the terminal)

## Key files

- Models/Student.cs              → Model
- Controllers/StudentsController.cs → Controller (Details action)
- Views/Students/Details.cshtml → View
- Program.cs                    → routing setup
