using System;
using Xplosive.Adaptors;
using Xplosive.Data;
using Xplosive.Models;
using Xplosive.Viewmodels;

namespace Xplosive.Services
{
    public class SetService
    {
        private readonly WorkoutService workoutService;
        private readonly XplosiveDbContext dbContext;
        private readonly SetAdaptor setAdaptor;

        public SetService(WorkoutService workoutService, XplosiveDbContext dbContext, SetAdaptor setAdaptor)
        {
            this.workoutService = workoutService;
            this.dbContext = dbContext;
            this.setAdaptor = setAdaptor;
        }

        public void CreateSet(SetViewmodel viewModel)
        {
            var dailyWorkout = workoutService.GetDailyWorkout(DateTime.Now);

            var set = this.setAdaptor.GetSetModel(viewModel, dailyWorkout);

            dbContext.Sets.Add(set);
            dbContext.SaveChanges();
        }
    }
}
