using Microsoft.AspNetCore.Identity;
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

            modelBuilder.Entity<DailyInfo>().HasOne(n => n.Nutrition).WithOne(i => i.DailyInfo).HasForeignKey<DailyNutrition>(n => n.DailyInfoId);
            modelBuilder.Entity<DailyInfo>().HasOne(w => w.Workout).WithOne(i => i.DailyInfo).HasForeignKey<DailyWorkout>(w => w.DailyInfoId);

            modelBuilder.Entity<IdentityUser>(entity => entity.Property(m => m.NormalizedEmail).HasMaxLength(200));
            modelBuilder.Entity<IdentityUser>(entity => entity.Property(m => m.Id).HasMaxLength(200));
            modelBuilder.Entity<IdentityUser>(entity => entity.Property(m => m.NormalizedUserName).HasMaxLength(200));


            modelBuilder.Entity<IdentityRole>(entity => entity.Property(m => m.NormalizedName).HasMaxLength(200));
            modelBuilder.Entity<IdentityRole>(entity => entity.Property(m => m.Id).HasMaxLength(200));


            modelBuilder.Entity<IdentityUserLogin<string>>(entity => entity.Property(m => m.UserId).HasMaxLength(200));
            modelBuilder.Entity<IdentityUserLogin<string>>(entity => entity.Property(m => m.LoginProvider).HasMaxLength(200));
            modelBuilder.Entity<IdentityUserLogin<string>>(entity => entity.Property(m => m.ProviderKey).HasMaxLength(200));


            modelBuilder.Entity<IdentityUserRole<string>>(entity => entity.Property(m => m.UserId).HasMaxLength(200));
            modelBuilder.Entity<IdentityUserRole<string>>(entity => entity.Property(m => m.RoleId).HasMaxLength(200));


            modelBuilder.Entity<IdentityUserToken<string>>(entity => entity.Property(m => m.UserId).HasMaxLength(200));
            modelBuilder.Entity<IdentityUserToken<string>>(entity => entity.Property(m => m.LoginProvider).HasMaxLength(200));
            modelBuilder.Entity<IdentityUserToken<string>>(entity => entity.Property(m => m.Name).HasMaxLength(200));

            modelBuilder.Entity<IdentityUserClaim<string>>(entity => entity.Property(m => m.UserId).HasMaxLength(200));
            modelBuilder.Entity<IdentityRoleClaim<string>>(entity => entity.Property(m => m.RoleId).HasMaxLength(200));

        }
    }
}
