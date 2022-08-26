using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectsTracker.Models;
using ProjectsTracker.Response;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

namespace ProjectsTracker.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {

        private readonly EmployeesContext _context;

        public EmployeesController(EmployeesContext context)
        {
            _context = context;
        }


        [HttpGet("{search}")]
        public async Task<ActionResult<List<Employees>>> GetEmployee(string search)
        {
            if (_context.Employees == null)
                return NotFound();

            string pattern = @"-[a-zA-Z]+[\s|,]";
            RegexOptions options = RegexOptions.Multiline;
            foreach (Match m in Regex.Matches(search, pattern, options))
            {
                search = search.Replace(m.Value, string.Empty);
            }

            string[] arrSearch = search.Split(",");
            var employees = await _context.Employees
                .Where(o => arrSearch.Contains(o.Name) || 
                arrSearch.Contains(o.Project) || 
                arrSearch.Contains(o.Company) || 
                arrSearch.Contains(o.Role)).ToListAsync();

            return Ok(employees);
        }

        [HttpGet("{search}/{pagesize}/{pageindex}")]
        public async Task<ActionResult<List<Employees>>> GetEmployee(string search, int pagesize, int pageindex)
        {
            if (_context.Employees == null)
                return NotFound();

            string pattern = @"-[a-zA-Z]+[\s|,]";
            RegexOptions options = RegexOptions.Multiline;
            foreach (Match m in Regex.Matches(search, pattern, options))
            {
                search = search.Replace(m.Value, string.Empty);
            }

            string[] arrSearch = search.Split(",");
            var employees = await _context.Employees
                .Where(o => arrSearch.Contains(o.Name) ||
                arrSearch.Contains(o.Project) ||
                arrSearch.Contains(o.Company) ||
                arrSearch.Contains(o.Role)).ToListAsync();

            var pageCount = Math.Ceiling(employees.Count() / (double)pagesize);
    

            var response = new EmployeeResponse
            {
                Employees = employees,
                CurrentPage = pageindex,
                Pages = (int)pageCount,
                PageSize = (int)pagesize,
                Total = employees.Count
            };
            return Ok(response);
        }


    }
}
