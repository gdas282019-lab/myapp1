namespace FresherJobAdvisor.Models;

/// <summary>
/// The outcome of scoring a single JobRole against the user's profile.
/// </summary>
public class MatchResult
{
    public JobRole Job { get; set; } = default!;
    public double MatchScore { get; set; }
    public List<string> MatchedSkills { get; set; } = new();
    public List<string> MissingSkills { get; set; } = new();
    public bool DegreeMatches { get; set; }
    public bool ExperienceFits { get; set; }
}
