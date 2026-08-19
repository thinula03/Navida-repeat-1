using Microsoft.Extensions.Options;
using PUSL2020.PAS.Models;

namespace PUSL2020.PAS.Services;

public class StudentIdentityService : IStudentIdentityService
{
    private readonly StudentIdentityOptions _options;
    private readonly ILogger<StudentIdentityService> _logger;

    public StudentIdentityService(
        IOptions<StudentIdentityOptions> options,
        ILogger<StudentIdentityService> logger)
    {
        _options = options.Value;
        _logger = logger;
    }

    public StudentIdentity GetIdentity() =>
        new(_options.FullName, _options.StudentId, _options.LiveLocation);

    public void LogRequest(string activity)
    {
        _logger.LogInformation(
            "PAS Request: {Activity} | Full Name: {FullName} | Student ID: {StudentId} | Current Live Location: {LiveLocation}",
            activity,
            _options.FullName,
            _options.StudentId,
            _options.LiveLocation);
    }
}
