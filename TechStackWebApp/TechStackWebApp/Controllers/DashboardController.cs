using Microsoft.AspNetCore.Mvc;
using TechStackWebApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace TechStackWebApp.Controllers
{
    //[Authorize] - Attribute Protect this controller
    [Authorize]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            var persons = new List<Person>
            { 
                new Person{
                    Id =1,
                    Name="John",
                    Email="John@yahoo.com",
                    Company="ABCD corp",
                    Status="Open"
                },
                new Person {
                    Id =1,
                    Name="Danny",
                    Email="Danny@yahoo.com",
                    Company="XYZ corp",
                    Status="Close"
                }
            };

            return View();
        }
    }
}
