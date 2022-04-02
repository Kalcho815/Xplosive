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
    }
}
