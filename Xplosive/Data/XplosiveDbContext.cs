using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Xplosive.Models;

namespace Xplosive.Data
{
    public class XplosiveDbContext : IdentityDbContext
    {
        public XplosiveDbContext(DbContextOptions<XplosiveDbContext> options)
            : base(options)
        {
        }

        protected XplosiveDbContext()
        {
        }

        //TODO: Write tables
        public DbSet<DailyInfo> HealthcareActivities { get; set; }

        public DbSet<DailyNutrition> DailyNutritions{ get; set; }

        public DbSet<DailyWorkout> DailyWorkouts { get; set; }

        public DbSet<Food> Foods { get; set; }

        public DbSet<Set> Sets{ get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasMany(p => p.DailyInfos).WithOne(p => p.User);
        }
    }
}
