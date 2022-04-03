using System.Collections.Generic;
using Xplosive.Models;
using Xplosive.Viewmodels;

namespace Xplosive.Adaptors
{
    public class SetAdaptor
    {
        public List<SetViewmodel> GetSetVms(List<Set> sets)
        {
            var setVms = new List<SetViewmodel>();

            foreach (var set in sets)
            {
                var setVm = new SetViewmodel()
                {
                    Id = set.Id,  
                    ExerciseName = set.ExerciseName,
                    Number = set.Number,
                    RepCount = set.RepCount,
                    Weight = set.Weight,
                };

                setVms.Add(setVm);
            }

            return setVms;
        }

        public Set GetSetModel(SetViewmodel viewModel, DailyWorkout dailyWorkout)
        {
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
            return set;
        }
    }
}
