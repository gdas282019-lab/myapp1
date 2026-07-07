using FresherJobAdvisor.Models;

namespace FresherJobAdvisor.Data;

public static class JobCatalog
{
    public static readonly List<JobRole> Jobs = new()
    {
        new JobRole
        {
            Title = "Frontend Developer",
            Category = "Software Development",
            Icon = "🎨",
            Description = "Builds the user-facing parts of websites and web apps using modern JS frameworks.",
            RequiredSkills = new() { "HTML/CSS", "JavaScript", "React" },
            BonusSkills = new() { "TypeScript", "Vue.js", "Angular", "Git" },
            PreferredDegrees = new(),
            MinExperience = 0, MaxExperience = 2,
            SalaryRangeINR = "₹3.5 – 6 LPA"
        },
        new JobRole
        {
            Title = "Backend Developer",
            Category = "Software Development",
            Icon = "⚙️",
            Description = "Designs APIs, business logic, and database interactions that power applications.",
            RequiredSkills = new() { "SQL", "REST APIs" },
            BonusSkills = new() { "Python", "Java", "C#", "Node.js", "Git" },
            PreferredDegrees = new() { "Technical" },
            MinExperience = 0, MaxExperience = 2,
            SalaryRangeINR = "₹4 – 7 LPA"
        },
        new JobRole
        {
            Title = "Full Stack Developer",
            Category = "Software Development",
            Icon = "🧩",
            Description = "Works across both frontend and backend to ship complete features end-to-end.",
            RequiredSkills = new() { "HTML/CSS", "JavaScript", "SQL", "REST APIs" },
            BonusSkills = new() { "React", "Node.js", "ASP.NET", "Django", "Git" },
            PreferredDegrees = new() { "Technical" },
            MinExperience = 0, MaxExperience = 2,
            SalaryRangeINR = "₹4.5 – 8 LPA"
        },
        new JobRole
        {
            Title = ".NET Developer",
            Category = "Software Development",
            Icon = "🟣",
            Description = "Builds enterprise applications using C# and the ASP.NET ecosystem.",
            RequiredSkills = new() { "C#", "ASP.NET", "SQL" },
            BonusSkills = new() { "Azure", "Git", "REST APIs" },
            PreferredDegrees = new() { "Technical" },
            MinExperience = 0, MaxExperience = 2,
            SalaryRangeINR = "₹4 – 7 LPA"
        },
        new JobRole
        {
            Title = "Java Developer",
            Category = "Software Development",
            Icon = "☕",
            Description = "Develops robust backend systems and services using Java.",
            RequiredSkills = new() { "Java", "SQL" },
            BonusSkills = new() { "REST APIs", "Git", "Docker" },
            PreferredDegrees = new() { "Technical" },
            MinExperience = 0, MaxExperience = 2,
            SalaryRangeINR = "₹4 – 7 LPA"
        },
        new JobRole
        {
            Title = "Python Developer",
            Category = "Software Development",
            Icon = "🐍",
            Description = "Builds applications and services in Python, often with Django or Flask.",
            RequiredSkills = new() { "Python", "SQL" },
            BonusSkills = new() { "Django", "Flask", "REST APIs", "Git" },
            PreferredDegrees = new() { "Technical" },
            MinExperience = 0, MaxExperience = 2,
            SalaryRangeINR = "₹4 – 7 LPA"
        },
        new JobRole
        {
            Title = "Software Test Engineer (QA)",
            Category = "Quality Assurance",
            Icon = "🧪",
            Description = "Verifies software quality through manual and automated testing.",
            RequiredSkills = new() { "Manual Testing" },
            BonusSkills = new() { "Automation Testing", "Selenium", "API Testing", "SQL" },
            PreferredDegrees = new(),
            MinExperience = 0, MaxExperience = 2,
            SalaryRangeINR = "₹3.5 – 6 LPA"
        },
        new JobRole
        {
            Title = "Data Analyst",
            Category = "Data & Analytics",
            Icon = "📊",
            Description = "Turns raw data into dashboards and insights for business decisions.",
            RequiredSkills = new() { "SQL", "Excel" },
            BonusSkills = new() { "Power BI", "Tableau", "Statistics", "Data Visualization" },
            PreferredDegrees = new(),
            MinExperience = 0, MaxExperience = 2,
            SalaryRangeINR = "₹3.5 – 6.5 LPA"
        },
        new JobRole
        {
            Title = "Data Scientist / ML Engineer (Fresher)",
            Category = "Data & Analytics",
            Icon = "🤖",
            Description = "Builds predictive models and analyses data to solve business problems.",
            RequiredSkills = new() { "Python", "Statistics", "Machine Learning" },
            BonusSkills = new() { "Pandas", "Deep Learning", "SQL" },
            PreferredDegrees = new() { "Technical" },
            MinExperience = 0, MaxExperience = 2,
            SalaryRangeINR = "₹5 – 9 LPA"
        },
        new JobRole
        {
            Title = "Cloud Support Associate",
            Category = "Cloud & Infrastructure",
            Icon = "☁️",
            Description = "Helps deploy, monitor, and troubleshoot applications on cloud platforms.",
            RequiredSkills = new() { "AWS", "Linux" },
            BonusSkills = new() { "Azure", "GCP", "Networking", "Git" },
            PreferredDegrees = new(),
            MinExperience = 0, MaxExperience = 2,
            SalaryRangeINR = "₹3.5 – 6.5 LPA"
        },
        new JobRole
        {
            Title = "DevOps Engineer (Fresher)",
            Category = "Cloud & Infrastructure",
            Icon = "🔁",
            Description = "Automates build, deployment, and infrastructure pipelines.",
            RequiredSkills = new() { "Docker", "Git", "Linux" },
            BonusSkills = new() { "Kubernetes", "CI/CD", "AWS", "Terraform" },
            PreferredDegrees = new() { "Technical" },
            MinExperience = 0, MaxExperience = 3,
            SalaryRangeINR = "₹4.5 – 8 LPA"
        },
        new JobRole
        {
            Title = "Network Engineer",
            Category = "Networking & Security",
            Icon = "🌐",
            Description = "Sets up, maintains, and troubleshoots enterprise network infrastructure.",
            RequiredSkills = new() { "Networking", "CCNA" },
            BonusSkills = new() { "Firewalls", "Linux" },
            PreferredDegrees = new(),
            MinExperience = 0, MaxExperience = 2,
            SalaryRangeINR = "₹3 – 5.5 LPA"
        },
        new JobRole
        {
            Title = "SOC Analyst (Cybersecurity)",
            Category = "Networking & Security",
            Icon = "🛡️",
            Description = "Monitors security alerts and responds to threats in a Security Operations Center.",
            RequiredSkills = new() { "SOC Operations", "Cybersecurity Fundamentals" },
            BonusSkills = new() { "Networking", "Firewalls", "OWASP Top 10" },
            PreferredDegrees = new(),
            MinExperience = 0, MaxExperience = 2,
            SalaryRangeINR = "₹3.5 – 6 LPA"
        },
        new JobRole
        {
            Title = "VAPT / Penetration Tester (Fresher)",
            Category = "Networking & Security",
            Icon = "🕵️",
            Description = "Finds and reports security vulnerabilities in applications and networks.",
            RequiredSkills = new() { "VAPT", "OWASP Top 10" },
            BonusSkills = new() { "Burp Suite", "Networking", "Cybersecurity Fundamentals" },
            PreferredDegrees = new() { "Technical" },
            MinExperience = 0, MaxExperience = 2,
            SalaryRangeINR = "₹4 – 7 LPA"
        },
        new JobRole
        {
            Title = "System Administrator",
            Category = "Cloud & Infrastructure",
            Icon = "🖥️",
            Description = "Manages servers, user access, and day-to-day IT infrastructure operations.",
            RequiredSkills = new() { "Linux", "Networking" },
            BonusSkills = new() { "Git", "AWS", "Firewalls" },
            PreferredDegrees = new(),
            MinExperience = 0, MaxExperience = 2,
            SalaryRangeINR = "₹3 – 5.5 LPA"
        },
        new JobRole
        {
            Title = "Database Administrator (Fresher)",
            Category = "Data & Analytics",
            Icon = "🗄️",
            Description = "Maintains, tunes, and secures organizational databases.",
            RequiredSkills = new() { "SQL", "Linux" },
            BonusSkills = new() { "AWS", "Git" },
            PreferredDegrees = new() { "Technical" },
            MinExperience = 0, MaxExperience = 3,
            SalaryRangeINR = "₹3.5 – 6 LPA"
        },
        new JobRole
        {
            Title = "Android Developer",
            Category = "Mobile Development",
            Icon = "📱",
            Description = "Builds native Android applications.",
            RequiredSkills = new() { "Android (Kotlin)" },
            BonusSkills = new() { "Java", "REST APIs", "Git" },
            PreferredDegrees = new(),
            MinExperience = 0, MaxExperience = 2,
            SalaryRangeINR = "₹3.5 – 6.5 LPA"
        },
        new JobRole
        {
            Title = "Cross-Platform Mobile Developer",
            Category = "Mobile Development",
            Icon = "📲",
            Description = "Builds apps for both Android and iOS from a single codebase.",
            RequiredSkills = new() { "Flutter" },
            BonusSkills = new() { "React Native", "JavaScript", "Git" },
            PreferredDegrees = new(),
            MinExperience = 0, MaxExperience = 2,
            SalaryRangeINR = "₹3.5 – 6.5 LPA"
        },
        new JobRole
        {
            Title = "UI/UX Designer",
            Category = "Design",
            Icon = "🖌️",
            Description = "Designs intuitive, user-friendly interfaces and experiences.",
            RequiredSkills = new() { "Figma", "UI/UX Design" },
            BonusSkills = new() { "Adobe XD", "Wireframing" },
            PreferredDegrees = new(),
            MinExperience = 0, MaxExperience = 2,
            SalaryRangeINR = "₹3 – 6 LPA"
        },
        new JobRole
        {
            Title = "Business / Systems Analyst",
            Category = "Business",
            Icon = "📈",
            Description = "Bridges business needs and technical teams, documents requirements.",
            RequiredSkills = new() { "Excel", "Communication" },
            BonusSkills = new() { "SQL", "Problem Solving", "Project Management" },
            PreferredDegrees = new(),
            MinExperience = 0, MaxExperience = 3,
            SalaryRangeINR = "₹3.5 – 6.5 LPA"
        },
        new JobRole
        {
            Title = "Technical Support Engineer",
            Category = "Business",
            Icon = "🛠️",
            Description = "Resolves customer-facing technical issues for products and services.",
            RequiredSkills = new() { "Communication", "Problem Solving" },
            BonusSkills = new() { "Networking", "Linux" },
            PreferredDegrees = new(),
            MinExperience = 0, MaxExperience = 2,
            SalaryRangeINR = "₹2.5 – 4.5 LPA"
        },
    };
}
