namespace FresherJobAdvisor.Models;

/// <summary>
/// Represents a single job role in the catalog that a fresher could be matched against.
/// </summary>
public class JobRole
{
    public string Title { get; set; } = "";
    public string Category { get; set; } = "";
    public string Icon { get; set; } = "💼";
    public string Description { get; set; } = "";

    /// <summary>Skills that strongly define this role.</summary>
    public List<string> RequiredSkills { get; set; } = new();

    /// <summary>Skills that are a nice-to-have and boost the match score.</summary>
    public List<string> BonusSkills { get; set; } = new();

    /// <summary>Degree categories preferred for this role. Empty list = open to any degree.</summary>
    public List<string> PreferredDegrees { get; set; } = new();

    public int MinExperience { get; set; } = 0;
    public int MaxExperience { get; set; } = 2;

    public string SalaryRangeINR { get; set; } = "";
}
