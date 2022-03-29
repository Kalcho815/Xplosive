using Microsoft.AspNetCore.Mvc;

namespace Xplosive.Controllers
{
    public class WorkoutController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(string exerciseId)
        {
            return View();
        }
    }
}
