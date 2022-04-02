using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Globalization;
using System.Linq;
using Xplosive.Adaptors;
using Xplosive.Data;
using Xplosive.Models;
using Xplosive.Viewmodels;

namespace Xplosive.Services
{
    public class WorkoutService
    {
        private readonly XplosiveDbContext dbContext;
        private readonly SetAdaptor setAdaptor;
        private readonly IHttpContextAccessor httpContext;
        private readonly string username;
        private User user;

        public WorkoutService()
        {

        }

        public WorkoutService(XplosiveDbContext dbContext, SetAdaptor setAdaptor, IHttpContextAccessor httpContextAccessor)
        {
            this.dbContext = dbContext;
            this.setAdaptor = setAdaptor;
            this.httpContext = httpContextAccessor;
            this.username = httpContext.HttpContext.User.Identity.Name;

            if (username != null)
            {
                this.user = dbContext.Users
                    .Include(u => u.DailyInfos)
                    .ThenInclude(d => d.Workout)
                    .ThenInclude(u => u.Sets)
                    .Where(u => u.UserName == username)
                    .FirstOrDefault();
            }
        }

        public void DeleteSet(string setId)
        {
            Set setToDelete = null;
            var userDailyInfos = this.user.DailyInfos;

            foreach (var dailyInfo in userDailyInfos)
            {
                foreach (var set in dailyInfo.Workout.Sets)
                {
                    if (set.Id == setId)
                    {
                        setToDelete = set;
                    }
                }
            }

            if (setToDelete != null)
            {
                dbContext.Sets.Remove(setToDelete);
                dbContext.SaveChanges();
            }
        }

        public DailyWorkout GetDailyWorkout(DateTime date)
        {
            var userSearch = dbContext.Users
                .Include(u => u.DailyInfos)
                .ThenInclude(y => y.Workout)
                .ThenInclude(s => s.Sets)
                .Where(u => u.UserName == username)
                .FirstOrDefault();

            DailyWorkout dailyWorkout = null;

            foreach (var dailyInfo in userSearch.DailyInfos)
            {
                if (dailyInfo.Workout.Date.ToShortDateString() == date.Date.ToShortDateString())
                {
                    dailyWorkout = dailyInfo.Workout;
                    break;
                }
            }

            return dailyWorkout;
        }

        public DailyWorkout GetDailyWorkout()
        {
            var dailyWorkout = dbContext.DailyWorkouts
                .Where(d => d.Date.ToString("d") == DateTime.Now.ToString("d")).FirstOrDefault();

            return dailyWorkout;
        }

        public DailyWorkoutViewModel GetWorkoutVm(DateTime date)
        {
            var workout = this.GetDailyWorkout(date);

            var workoutVm = new DailyWorkoutViewModel
            {
                Date = date,
                Sets = setAdaptor.GetSetVms(workout.Sets),
                Log = workout.Log,
            };

            return workoutVm;
        }
    }
}
