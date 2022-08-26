using Microsoft.EntityFrameworkCore;
using ProjectsTracker.Models;

namespace ProjectsTracker.Helper
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employees>().HasData(
                 new Employees { RecordID = 1, Name = "Ankur", Company = "IBM", Project = "Payroll", Role = "Software Engineer" },
                new Employees { RecordID = 2, Name = "Akash", Company = "IBM", Project = "Chatbot", Role = "Software Engineer" },
                new Employees { RecordID = 3, Name = "Priya", Company = "HP", Project = "VR Gaming", Role = "Project Manager" },
                new Employees { RecordID = 4, Name = "Asha", Company = "Microsoft", Project = "Payroll", Role = "Solutions Architect" },
                new Employees { RecordID = 5, Name = "Nandini", Company = "HP", Project = "Payroll", Role = "Software Engineer" },
                new Employees { RecordID = 6, Name = "Piyush", Company = "Microsoft", Project = "Payroll", Role = "Delivery Manager" },
                new Employees { RecordID = 7, Name = "Ankur", Company = "HP", Project = "Chatbot", Role = "Lead Engineer" },
                new Employees { RecordID = 8, Name = "Akash", Company = "HP", Project = "VR Gaming", Role = "Software Engineer" },
                new Employees { RecordID = 9, Name = "Priya", Company = "IBM", Project = "Payroll", Role = "Software Engineer" },
                new Employees { RecordID = 10, Name = "Asha", Company = "HP", Project = "Chatbot", Role = "Delivery Manager" },
                new Employees { RecordID = 11, Name = "Nandini", Company = "IBM", Project = "VR Gaming", Role = "Lead Engineer" },
                new Employees { RecordID = 12, Name = "Piyush", Company = "Microsoft", Project = "Chatbot", Role = "Delivery Manager" }
                );
        }
    }
}
