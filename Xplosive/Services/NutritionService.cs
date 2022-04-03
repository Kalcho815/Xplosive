using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Xplosive.Data;
using Xplosive.Models;

namespace Xplosive.Services
{
    public class NutritionService
    {
        private readonly XplosiveDbContext dbContext;
        private IHttpContextAccessor httpContext;
        private string username;
        private User user;

        public NutritionService(XplosiveDbContext dbContext, IHttpContextAccessor httpContextAccessor)
        {
            this.dbContext = dbContext;
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

        public DailyNutrition GetDailyNutrition(DateTime date)
        {
            var userSearch = dbContext.Users
                .Include(u => u.DailyInfos)
                .ThenInclude(y => y.Nutrition)
                .ThenInclude(s => s.Foods)
                .Where(u => u.UserName == username)
                .FirstOrDefault();

            DailyNutrition dailyNutrition = null;

            foreach (var dailyInfo in userSearch.DailyInfos)
            {
                if (dailyInfo.Nutrition.Date.ToShortDateString() == date.Date.ToShortDateString())
                {
                    dailyNutrition = dailyInfo.Nutrition;
                    break;
                }
            }

            return dailyNutrition;
        }
    }
}
