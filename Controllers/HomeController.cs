using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PUSL2020.PAS.Data;
using PUSL2020.PAS.Models;
using PUSL2020.PAS.Services;

namespace PUSL2020.PAS.Controllers;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly IStudentIdentityService _identityService;

    public HomeController(ApplicationDbContext context, IStudentIdentityService identityService)
    {
        _context = context;
        _identityService = identityService;
    }

    [HttpGet]
    public async Task<IActionResult> Index(string? searchTerm)
    {
        _identityService.LogRequest(string.IsNullOrWhiteSpace(searchTerm)
            ? "Home page loaded"
            : $"Supervisor search: {searchTerm}");

        var viewModel = await BuildViewModel(searchTerm);
        return View(viewModel);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> SubmitProposal(
        [Bind(Prefix = "Proposal")] ProposalSubmission proposal,
        string? searchTerm)
    {
        _identityService.LogRequest(ModelState.IsValid
            ? "Valid proposal form submitted"
            : "Invalid proposal form submitted");

        var viewModel = await BuildViewModel(searchTerm);
        viewModel.Proposal = proposal;

        if (!ModelState.IsValid)
        {
            viewModel.SubmissionMessage = "Please correct the highlighted fields and submit again.";
            return View("Index", viewModel);
        }

        ModelState.Clear();
        viewModel.Proposal = new ProposalSubmission();
        viewModel.SubmissionMessage = "Thank you for your submission. Your proposal has been received.";
        return View("Index", viewModel);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    private async Task<HomeViewModel> BuildViewModel(string? searchTerm)
    {
        IQueryable<Supervisor> query = _context.Supervisors.AsNoTracking();

        if (!string.IsNullOrWhiteSpace(searchTerm))
        {
            var term = $"%{searchTerm.Trim()}%";
            query = query.Where(supervisor =>
                EF.Functions.Like(supervisor.Name, term) ||
                EF.Functions.Like(supervisor.OfficeLocation, term));
        }

        return new HomeViewModel
        {
            Identity = _identityService.GetIdentity(),
            Supervisors = await query.OrderBy(supervisor => supervisor.Name).ToListAsync(),
            SearchTerm = searchTerm
        };
    }
}
