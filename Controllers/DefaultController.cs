using Microsoft.AspNetCore.Mvc;
using ReflectedXss.Models;
using ReflectedXss.Services;

namespace ReflectedXss.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IEmployeeService employeeService;

        public DefaultController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        [HttpGet("/")]
        public IActionResult Index(string query)
        {
            var searchResult = new SearchResultModel
            {
                Employees = this.employeeService.GetEmployeesByName(query),
                SearchTerm = query,
            };
            return View(searchResult);
        }

        [HttpPost("/")]
        public IActionResult DoSearch(string query)
        {

            return RedirectToAction("Index", new { query = query });
        }
     }
}