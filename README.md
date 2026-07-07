# CareerCompass — Fresher Job Suggestion App

A fully **client-side, static** web app built with **Blazor WebAssembly (.NET 8)** that
suggests fresher-friendly jobs based on **degree, years of experience, and skills**.
There is no backend/server and no external API — all matching logic runs inside the
browser via WebAssembly, so once published it is just static HTML/CSS/JS/WASM files
that can be hosted anywhere (GitHub Pages, Netlify, Azure Static Web Apps, S3, etc.).

## Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) installed on your machine
  (this sandbox doesn't have internet access to NuGet, so the project couldn't be
  built/tested here — but the code is standard Blazor WASM and will restore normally
  on a machine with internet access).

## Run it locally

```bash
cd FresherJobAdvisor
dotnet restore
dotnet run
```

Then open the URL shown in the terminal (typically `https://localhost:5001` or similar).

## Publish as static files

```bash
dotnet publish -c Release -o publish
```

The deployable static site will be in `publish/wwwroot`. Upload that folder's contents
to any static host. For GitHub Pages, you'll typically also want to add a
`404.html` (copy of `index.html`) and adjust the `<base href>` tag to match your repo
path.

## Project structure

```
FresherJobAdvisor/
├── FresherJobAdvisor.csproj      # Blazor WebAssembly project file
├── Program.cs                    # App entry point
├── App.razor                     # Root component
├── Home.razor                    # Main UI: form + results
├── _Imports.razor
├── Models/
│   ├── JobRole.cs                # Job role data shape
│   └── MatchResult.cs            # Scored match result shape
├── Data/
│   ├── JobCatalog.cs             # ~20 fresher-friendly job roles
│   ├── SkillCatalog.cs           # Skills grouped by category (chip picker)
│   └── DegreeCatalog.cs          # Degree options + broad category tags
├── Services/
│   └── JobMatchingService.cs     # Rule-based scoring/matching engine
└── wwwroot/
    ├── index.html
    ├── favicon.svg
    └── css/app.css               # The "super UI" styling
```

## How the matching works

For each job role, `JobMatchingService` scores your profile out of 100:

- **Required skills match** — up to 70 points, proportional to how many of the role's
  required skills you selected.
- **Bonus skills match** — up to 10 points for nice-to-have skills.
- **Degree fit** — up to 15 points if your degree's category (Technical / Commerce /
  Management / General) matches what the role prefers (many roles accept any degree).
- **Experience fit** — up to 15 points if your years of experience fall inside the
  role's typical fresher-friendly range, tapering off the further outside it you are.

Results are sorted by score, and the top match is flagged "🏆 Top Pick". Each card also
shows which of your skills matched and which skills are worth learning to close the gap.

## Customizing

- Add/edit job roles in `Data/JobCatalog.cs`.
- Add/edit skills in `Data/SkillCatalog.cs` (they auto-appear in the picker).
- Add/edit degrees in `Data/DegreeCatalog.cs`.
- Tweak colors/fonts/spacing in `wwwroot/css/app.css` (CSS variables at the top of the file).
