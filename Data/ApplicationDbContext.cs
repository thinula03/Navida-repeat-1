using Microsoft.EntityFrameworkCore;
using PUSL2020.PAS.Models;

namespace PUSL2020.PAS.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Supervisor> Supervisors => Set<Supervisor>();
    public DbSet<ProposalRecord> ProposalRecords => Set<ProposalRecord>();
}
