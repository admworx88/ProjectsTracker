using ProjectsTracker.Models;

namespace ProjectsTracker.Response
{
    public class EmployeeResponse
    {
        public List<Employees> Employees { get; set; } = new List<Employees>();
        public int Total { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int Pages { get; set; }

    }
}
