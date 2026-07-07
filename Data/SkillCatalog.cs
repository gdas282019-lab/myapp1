namespace FresherJobAdvisor.Data;

public static class SkillCatalog
{
    public static readonly Dictionary<string, List<string>> Groups = new()
    {
        ["Programming Languages"] = new()
        {
            "C", "C++", "Java", "Python", "C#", "JavaScript", "TypeScript", "PHP", "Go", "R"
        },
        ["Web Development"] = new()
        {
            "HTML/CSS", "React", "Angular", "Vue.js", "Node.js", "ASP.NET", "Django", "Flask", "REST APIs"
        },
        ["Data & Analytics"] = new()
        {
            "SQL", "Excel", "Power BI", "Tableau", "Pandas", "Machine Learning", "Deep Learning", "Statistics", "Data Visualization"
        },
        ["Cloud & DevOps"] = new()
        {
            "AWS", "Azure", "GCP", "Docker", "Kubernetes", "CI/CD", "Linux", "Terraform", "Git"
        },
        ["Networking & Security"] = new()
        {
            "Networking", "CCNA", "Firewalls", "VAPT", "SOC Operations", "Burp Suite", "OWASP Top 10", "Cybersecurity Fundamentals"
        },
        ["Mobile Development"] = new()
        {
            "Android (Kotlin)", "iOS (Swift)", "Flutter", "React Native"
        },
        ["Design"] = new()
        {
            "Figma", "Adobe XD", "UI/UX Design", "Wireframing"
        },
        ["Testing"] = new()
        {
            "Manual Testing", "Automation Testing", "Selenium", "API Testing"
        },
        ["Soft Skills"] = new()
        {
            "Communication", "Teamwork", "Problem Solving", "Project Management", "Leadership"
        },
    };
}
