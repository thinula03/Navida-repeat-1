using System.ComponentModel.DataAnnotations;

namespace PUSL2020.PAS.Models;

public class ProposalRecord
{
    public int Id { get; set; }

    [Required]
    public string StudentName { get; set; } = string.Empty;

    [Required]
    public string Email { get; set; } = string.Empty;

    [Required]
    public string ProjectAbstract { get; set; } = string.Empty;

    public DateTime SubmittedAtUtc { get; set; } = DateTime.UtcNow;
}
