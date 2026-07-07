namespace FresherJobAdvisor.Data;

public static class DegreeCatalog
{
    /// <summary>
    /// Each degree is tagged with a broad category used for matching against JobRole.PreferredDegrees.
    /// </summary>
    public static readonly List<(string Name, string Category)> Degrees = new()
    {
        ("B.Tech / B.E. (CSE, IT or ECE)", "Technical"),
        ("B.Tech / B.E. (Other branch)", "Technical-General"),
        ("BCA", "Technical"),
        ("MCA", "Technical"),
        ("B.Sc (Computer Science / IT)", "Technical"),
        ("M.Sc (Computer Science / IT)", "Technical"),
        ("Diploma in Engineering (CS/IT)", "Technical"),
        ("B.Com / M.Com", "Commerce"),
        ("BBA / MBA", "Management"),
        ("Other Graduate Degree", "General"),
    };

    public static List<string> Names => Degrees.Select(d => d.Name).ToList();

    public static string CategoryFor(string name) =>
        Degrees.FirstOrDefault(d => d.Name == name).Category ?? "General";
}
