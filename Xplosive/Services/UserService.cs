using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Xplosive.Data;
using Xplosive.Models;

namespace Xplosive.Services
{
    public class UserService
    {
        private readonly XplosiveDbContext dbContext;
        private readonly IHttpContextAccessor httpContext;
        private string username;
        private User user;

        public UserService(XplosiveDbContext dbContext, IHttpContextAccessor httpContext)
        {
            this.dbContext = dbContext;
            this.httpContext = httpContext;

            this.username = httpContext.HttpContext.User.Identity.Name;
            if (username != null)
            {
                this.user = dbContext.Users.Include(u => u.DailyInfos).ThenInclude(d => d.Workout).Where(u => u.UserName == username).FirstOrDefault();
            }
        }

        public void CheckAndCreateWorkout()
        {
            

            if (!user.DailyInfos.Any(d => d.Date.ToString("d") == DateTime.Now.ToString("d")))
            {
                var dailyWorkout = new DailyWorkout
                {
                    Date = DateTime.Now,
                };

                var dailyNutrition = new DailyNutrition
                {
                    Date = DateTime.Now
                };

                var dailyInfo = new DailyInfo
                {
                    Date = DateTime.Now,
                    Nutrition = dailyNutrition,
                    Workout = dailyWorkout,
                    User = user,
                };

                dbContext.DailyInfos.Add(dailyInfo);
                dbContext.SaveChanges();
            }
        }
    }
}
