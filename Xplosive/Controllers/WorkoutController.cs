using Microsoft.AspNetCore.Mvc;
using Xplosive.Viewmodels;

namespace Xplosive.Controllers
{
    public class WorkoutController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(SetViewmodel setViewmodel)
        {
            return View();
        }
    }
}
