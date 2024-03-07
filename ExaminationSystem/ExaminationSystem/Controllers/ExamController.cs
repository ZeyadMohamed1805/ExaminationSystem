using Microsoft.AspNetCore.Mvc;

namespace ExaminationSystem.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Course(int Id)
        {
            return View();
        }
    }
}
