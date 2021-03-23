using JobTrackingProject.Business.Concrete;
using JobTrackingProject.Business.Interfaces;
using JobTrackingProject.DataAccess.Concrete.EntitiyFrameworkCore.Contexts;
using JobTrackingProject.DataAccess.Concrete.EntitiyFrameworkCore.Repositories;
using JobTrackingProject.DataAccess.Interfaces;
using JobTrackingProject.Entities.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTrackingProject.Web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IDutyService, DutyManager>();
            services.AddScoped<IImportanceService, ImportanceManager>();
            services.AddScoped<IReportService, ReportManager>();
            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<INotificationService, NotificationManager>();

            services.AddScoped<IDutyDal, EfDutyRepository>();
            services.AddScoped<IImportanceDal,EfImportanceRepository>();
            services.AddScoped<IReportDal, EfReportRepository>();
            services.AddScoped<IAppUserDal, EfAppUserRepository>();
            services.AddScoped<INotificationDal, EfNotificationRepository>();

            services.AddDbContext<JobTrackingProjectContext>();
            services.AddIdentity<AppUser, AppRole>(opt => {
                opt.Password.RequireDigit = false;
                opt.Password.RequireUppercase = false;
                opt.Password.RequiredLength = 1;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireNonAlphanumeric = false;            
            }).AddEntityFrameworkStores<JobTrackingProjectContext>();
            services.AddControllersWithViews();

            services.ConfigureApplicationCookie(opt => {
                opt.Cookie.Name = "JobTrackingCookie";
                opt.Cookie.SameSite = SameSiteMode.Strict;
                opt.ExpireTimeSpan = TimeSpan.FromDays(20);
                opt.Cookie.HttpOnly = true;
                opt.Cookie.SecurePolicy= CookieSecurePolicy.SameAsRequest;
                opt.LoginPath = "/Home/Index";
            
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,UserManager<AppUser> userManager,RoleManager<AppRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseAuthorization();
            IdenitiyInitializer.SeedData(userManager, roleManager).Wait();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name:"areas",
                    pattern:"{area}/{controller=Home}/{action=Index}/{id?}"
                    );

                endpoints.MapControllerRoute(
                    name:"default",
                    pattern:"{controller=Home}/{action=Index}/{id?}"
                    );
            });
        }
    }
}
