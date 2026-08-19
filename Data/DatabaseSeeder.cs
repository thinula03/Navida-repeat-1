using PUSL2020.PAS.Models;

namespace PUSL2020.PAS.Data;

public static class DatabaseSeeder
{
    public static void Seed(ApplicationDbContext context)
    {
        if (context.Supervisors.Any())
        {
            return;
        }

        context.Supervisors.AddRange(
            new Supervisor { Name = "Dr. Anjali Perera", OfficeLocation = "Computing Block A - Room 201", ContactNumber = "+94 11 222 1001", Latitude = 6.927079, Longitude = 79.861244 },
            new Supervisor { Name = "Prof. Michael Fernando", OfficeLocation = "Engineering Faculty - Room 118", ContactNumber = "+94 11 222 1002", Latitude = 6.928810, Longitude = 79.862340 },
            new Supervisor { Name = "Dr. Sanduni Jayasinghe", OfficeLocation = "Research Centre - Lab 03", ContactNumber = "+94 11 222 1003", Latitude = 6.926420, Longitude = 79.860110 },
            new Supervisor { Name = "Ms. Kavindi Silva", OfficeLocation = "Computing Block B - Room 305", ContactNumber = "+94 11 222 1004", Latitude = 6.929520, Longitude = 79.863190 },
            new Supervisor { Name = "Dr. Nuwan Rajapaksha", OfficeLocation = "Innovation Hub - Desk 12", ContactNumber = "+94 11 222 1005", Latitude = 6.925760, Longitude = 79.859870 },
            new Supervisor { Name = "Prof. Harini Wickramasinghe", OfficeLocation = "Graduate School - Room 2.4", ContactNumber = "+94 11 222 1006", Latitude = 6.930010, Longitude = 79.864220 },
            new Supervisor { Name = "Mr. Roshan Gunawardena", OfficeLocation = "Software Lab - Room 107", ContactNumber = "+94 11 222 1007", Latitude = 6.927610, Longitude = 79.858990 }
        );

        context.SaveChanges();
    }
}
