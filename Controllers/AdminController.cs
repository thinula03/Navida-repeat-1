using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PUSL2020.PAS.Data;
using PUSL2020.PAS.Models;
using PUSL2020.PAS.Services;

namespace PUSL2020.PAS.Controllers;

public class AdminController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly IStudentIdentityService _identityService;

    public AdminController(ApplicationDbContext context, IStudentIdentityService identityService)
    {
        _context = context;
        _identityService = identityService;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        _identityService.LogRequest("Admin dashboard loaded");

        var viewModel = new AdminDashboardViewModel
        {
            Identity = _identityService.GetIdentity(),
            Supervisors = await _context.Supervisors
                .AsNoTracking()
                .OrderBy(supervisor => supervisor.Name)
                .ToListAsync(),
            ProposalRecords = await _context.ProposalRecords
                .AsNoTracking()
                .OrderByDescending(proposal => proposal.SubmittedAtUtc)
                .Take(10)
                .ToListAsync()
        };

        return View(viewModel);
    }
}
