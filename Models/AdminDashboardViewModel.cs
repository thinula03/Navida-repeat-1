namespace PUSL2020.PAS.Models;

public class AdminDashboardViewModel
{
    public StudentIdentity Identity { get; set; } = new("YOUR FULL NAME", "YOUR STUDENT ID", "Colombo, Sri Lanka");
    public IReadOnlyList<Supervisor> Supervisors { get; set; } = Array.Empty<Supervisor>();
    public IReadOnlyList<ProposalRecord> ProposalRecords { get; set; } = Array.Empty<ProposalRecord>();
    public int SupervisorCount => Supervisors.Count;
    public int ProposalCount => ProposalRecords.Count;
    public int ModuleCoverage => 5;
}
