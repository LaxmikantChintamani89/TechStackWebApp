using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace TechStackWebApp.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string Status { get; set; }
    }
}
