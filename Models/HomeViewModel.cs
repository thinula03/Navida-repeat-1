namespace PUSL2020.PAS.Models;

public class HomeViewModel
{
    public StudentIdentity Identity { get; set; } = new("YOUR FULL NAME", "YOUR STUDENT ID", "Colombo, Sri Lanka");
    public IReadOnlyList<Supervisor> Supervisors { get; set; } = Array.Empty<Supervisor>();
    public string? SearchTerm { get; set; }
    public double DepartmentLatitude { get; set; } = 6.927079;
    public double DepartmentLongitude { get; set; } = 79.861244;
    public double ResearcherLatitude { get; set; } = 6.928450;
    public double ResearcherLongitude { get; set; } = 79.862100;
    public string? SubmissionMessage { get; set; }
    public ProposalSubmission Proposal { get; set; } = new();
    public int ResultCount => Supervisors.Count;
    public string SearchStatus => string.IsNullOrWhiteSpace(SearchTerm) ? "All records" : $"Filtered by \"{SearchTerm}\"";
    public int WorkflowCompletion => 100;
}
