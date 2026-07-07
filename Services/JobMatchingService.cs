using FresherJobAdvisor.Data;
using FresherJobAdvisor.Models;

namespace FresherJobAdvisor.Services;

/// <summary>
/// Pure client-side rule-based matching engine. No network calls — everything
/// runs inside the browser via Blazor WebAssembly.
/// </summary>
public class JobMatchingService
{
    public List<MatchResult> FindMatches(IEnumerable<string> userSkills, int yearsExperience, string degreeName)
    {
        var userSkillSet = userSkills.ToHashSet(StringComparer.OrdinalIgnoreCase);
        var degreeCategory = DegreeCatalog.CategoryFor(degreeName);

        var results = new List<MatchResult>();

        foreach (var job in JobCatalog.Jobs)
        {
            var matchedRequired = job.RequiredSkills
                .Where(s => userSkillSet.Contains(s))
                .ToList();

            var matchedBonus = job.BonusSkills
                .Where(s => userSkillSet.Contains(s))
                .ToList();

            var missing = job.RequiredSkills
                .Where(s => !userSkillSet.Contains(s))
                .ToList();

            // Required skills carry the most weight (up to 70 pts)
            double skillScore = job.RequiredSkills.Count == 0
                ? 35
                : (double)matchedRequired.Count / job.RequiredSkills.Count * 70.0;

            // Bonus skills add a little extra polish (up to 10 pts)
            double bonusScore = job.BonusSkills.Count == 0
                ? 0
                : Math.Min(10.0, (double)matchedBonus.Count / job.BonusSkills.Count * 10.0);

            // Degree fit (up to 15 pts, small residual credit even if it doesn't match)
            bool degreeMatches = job.PreferredDegrees.Count == 0 || job.PreferredDegrees.Contains(degreeCategory);
            double degreeScore = degreeMatches ? 15.0 : 4.0;

            // Experience fit (up to 15 pts, tapering off the further outside the range)
            bool experienceFits = yearsExperience >= job.MinExperience && yearsExperience <= job.MaxExperience;
            double experienceScore;
            if (experienceFits)
            {
                experienceScore = 15.0;
            }
            else
            {
                int distance = yearsExperience < job.MinExperience
                    ? job.MinExperience - yearsExperience
                    : yearsExperience - job.MaxExperience;
                experienceScore = Math.Max(0, 15.0 - distance * 5.0);
            }

            double total = Math.Round(skillScore + bonusScore + degreeScore + experienceScore, 1);
            total = Math.Min(total, 100);

            results.Add(new MatchResult
            {
                Job = job,
                MatchScore = total,
                MatchedSkills = matchedRequired.Concat(matchedBonus).Distinct().ToList(),
                MissingSkills = missing,
                DegreeMatches = degreeMatches,
                ExperienceFits = experienceFits
            });
        }

        return results
            .OrderByDescending(r => r.MatchScore)
            .ThenBy(r => r.Job.Title)
            .ToList();
    }
}
