using Microsoft.AspNetCore.Mvc;

namespace ExaminationSystem.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
