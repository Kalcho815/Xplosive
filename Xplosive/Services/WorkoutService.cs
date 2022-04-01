using System;
using System.Linq;
using Xplosive.Data;
using Xplosive.Models;
using Xplosive.Viewmodels;

namespace Xplosive.Services
{
    public class WorkoutService
    {
        private readonly XplosiveDbContext dbContext;

        public WorkoutService()
        {

        }

        public WorkoutService(XplosiveDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void CreateSet(SetViewmodel viewModel)
        {
            var dailyWorkout = this.GetDailyWorkout();

            var set = new Set
            {
                Number = viewModel.Number,
                RepCount = viewModel.RepCount,
                Weight = viewModel.Weight,
                ExerciseId = viewModel.ExerciseId,
                ExerciseName = viewModel.ExerciseName,
                DailyWorkout = dailyWorkout,
            };

            dbContext.Sets.Add(set);
            dbContext.SaveChanges();
        }

        public DailyWorkout GetDailyWorkout()
        {
            var dailyWorkout = dbContext.DailyWorkouts.Where(d => d.Date.CompareTo(DateTime.Now) == 0).FirstOrDefault();

            return dailyWorkout;
        }
    }
}
