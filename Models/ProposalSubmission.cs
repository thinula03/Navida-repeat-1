using System.ComponentModel.DataAnnotations;

namespace PUSL2020.PAS.Models;

public class ProposalSubmission
{
    [Required(ErrorMessage = "Student name is required.")]
    [RegularExpression(@"^[A-Za-z]+(?:[ '\-][A-Za-z]+)*$", ErrorMessage = "Student name can only contain letters, spaces, apostrophes, and hyphens.")]
    [Display(Name = "Student Name")]
    public string StudentName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email address is required.")]
    [RegularExpression(@"^[A-Za-z0-9._%+\-]+@[A-Za-z0-9.\-]+\.[A-Za-z]{2,}$", ErrorMessage = "Enter a valid email address.")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Project abstract is required.")]
    [StringLength(750, MinimumLength = 30, ErrorMessage = "Project abstract must be between 30 and 750 characters.")]
    [Display(Name = "Project Abstract")]
    public string ProjectAbstract { get; set; } = string.Empty;
}
