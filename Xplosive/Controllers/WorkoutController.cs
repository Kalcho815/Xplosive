using Microsoft.AspNetCore.Mvc;
using Xplosive.Services;
using Xplosive.Viewmodels;

namespace Xplosive.Controllers
{
    public class WorkoutController : Controller
    {
        private WorkoutService workoutService;

        public WorkoutController(WorkoutService workoutService)
        {
            this.workoutService = workoutService;
        }

        public IActionResult Add(WorkoutService workoutService)
        {
            this.workoutService = workoutService;

            return View();
        }

        [HttpPost]
        public IActionResult Add(SetViewmodel setViewmodel)
        {
            workoutService.CreateSet(setViewmodel);

            return View();
        }
    }
}
