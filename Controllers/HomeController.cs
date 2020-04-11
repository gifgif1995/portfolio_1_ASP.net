using Microsoft.AspNetCore.Mvc;
namespace HelloASP
{
    public class HomeController : Controller
    {
        // Requests
        // localhost:5000/
        [HttpGet("")]
        public string Index()
        {
            return "This is My Index!";
        }

        // localhost:5000/projects
        [HttpGet("projects")]
        public string Hello()
        {
            return "These are my Projects!";
        }

        // localhost:5000/contact
        [HttpGet("contact")]
        public string Contact()
        {
            return "This is my Contact!";
        }

    }
}