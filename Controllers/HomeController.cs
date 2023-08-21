using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Portfolio.Custom.Helpers;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private IConfiguration Configuration;
        public HomeController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public ActionResult Email(string name, string username, string msg)
        {
            MailHelper mailHelper = new MailHelper(Configuration);

            return Json(mailHelper.SendEmail(name, username, msg));
        }
    }
}
