using System;
using Xplosive.Data;
using Xplosive.Models;
using Xplosive.Viewmodels;

namespace Xplosive.Services
{
    public class SetService
    {
        private readonly WorkoutService workoutService;
        private readonly XplosiveDbContext dbContext;

        public SetService(WorkoutService workoutService, XplosiveDbContext dbContext)
        {
            this.workoutService = workoutService;
            this.dbContext = dbContext;
        }

        public void CreateSet(SetViewmodel viewModel)
        {
            var dailyWorkout = workoutService.GetDailyWorkout(DateTime.Now);

            var set = new Set
            {
                Number = viewModel.Number,
                RepCount = viewModel.RepCount,
                Weight = viewModel.Weight,
                ExerciseId = viewModel.ExerciseId,
                ExerciseName = viewModel.ExerciseName,
                DailyWorkout = dailyWorkout,
                DailyWorkoutId = dailyWorkout.Id,
            };

            dbContext.Sets.Add(set);
            dbContext.SaveChanges();
        }
    }
}
