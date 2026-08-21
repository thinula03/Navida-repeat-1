using Microsoft.EntityFrameworkCore;
using PUSL2020.PAS.Data;
using PUSL2020.PAS.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
        ?? throw new InvalidOperationException("Missing DefaultConnection connection string.");

    options.UseSqlite(connectionString);
});
builder.Services.Configure<StudentIdentityOptions>(
    builder.Configuration.GetSection(StudentIdentityOptions.SectionName));
builder.Services.AddScoped<IStudentIdentityService, StudentIdentityService>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    db.Database.EnsureCreated();
    db.Database.ExecuteSqlRaw("""
        CREATE TABLE IF NOT EXISTS "ProposalRecords" (
            "Id" INTEGER NOT NULL CONSTRAINT "PK_ProposalRecords" PRIMARY KEY AUTOINCREMENT,
            "StudentName" TEXT NOT NULL,
            "Email" TEXT NOT NULL,
            "ProjectAbstract" TEXT NOT NULL,
            "SubmittedAtUtc" TEXT NOT NULL
        );
        """);
    DatabaseSeeder.Seed(db);
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
