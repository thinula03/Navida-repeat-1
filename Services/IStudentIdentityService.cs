using PUSL2020.PAS.Models;

namespace PUSL2020.PAS.Services;

public interface IStudentIdentityService
{
    StudentIdentity GetIdentity();
    void LogRequest(string activity);
}
