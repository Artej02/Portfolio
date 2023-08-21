using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult ResearchPanel()
        {
            return View();
        }

        public IActionResult Customs()
        {
            return View();
        }
    }
}
