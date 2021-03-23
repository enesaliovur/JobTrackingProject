using JobTrackingProject.DataAccess.Concrete.EntitiyFrameworkCore.Mapping;
using JobTrackingProject.Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTrackingProject.DataAccess.Concrete.EntitiyFrameworkCore.Contexts
{
    public class JobTrackingProjectContext : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-NQ2P98H; database=databaseJobTrackingProject;integrated Security=true;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DutyMap());
            modelBuilder.ApplyConfiguration(new AppUserMap());
            modelBuilder.ApplyConfiguration(new ImportanceMap());
            modelBuilder.ApplyConfiguration(new ReportMap());
            modelBuilder.ApplyConfiguration(new NotificationMap());

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Report> Reports { get; set; }
        public DbSet<Importance> Importances { get; set; }
        public DbSet<Duty> Duties { get; set; }
        public  DbSet<Notification> Notifications { get; set; }
    }
}
