using System.ComponentModel.DataAnnotations;

namespace PUSL2020.PAS.Models;

public class Supervisor
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    [Required]
    public string OfficeLocation { get; set; } = string.Empty;

    [Required]
    public string ContactNumber { get; set; } = string.Empty;

    public double Latitude { get; set; }

    public double Longitude { get; set; }
}
