using Microsoft.AspNetCore.Mvc;
using System;
using Xplosive.Services;
using Xplosive.Viewmodels;

namespace Xplosive.Controllers
{
    public class WorkoutController : Controller
    {
        private WorkoutService workoutService;
        private readonly SetService setService;

        public WorkoutController(WorkoutService workoutService, SetService setService)
        {
            this.workoutService = workoutService;
            this.setService = setService;
        }

        public IActionResult Add(WorkoutService workoutService)
        {
            this.workoutService = workoutService;

            return View();
        }

        [HttpPost]
        public IActionResult Add(SetViewmodel setViewmodel)
        {
            setService.CreateSet(setViewmodel);

            return View();
        }

        public IActionResult All(DateTime date)
        {
            var workoutVms = workoutService.GetWorkoutVm(date);

            return View(workoutVms);
        }

        [HttpPost]
        public IActionResult Delete(string setId)
        {
            workoutService.DeleteSet(setId);

            return this.RedirectToAction("All", new {date = DateTime.Now});
        }
    }
}
