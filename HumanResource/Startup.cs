using HumanResource.DataAccess;
using HumanResource.DataAccess.Interfaces;
using HumanResource.DataAccess.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Localization.Routing;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Globalization;

namespace HumanResource
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        public void ConfigureServices(IServiceCollection services)
        {
            #region DbContext
            services.AddDbContextPool<HumanResourceContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("HumanResourceDbContext")));

            #endregion
            #region DependencyInjection
            services.AddScoped<IEmployee, EmployeeRepository>();
            services.AddScoped<IDepartment, DepartmentRepository>();
            services.AddScoped<IEducation, EducationRepository>();
            services.AddScoped<IMission, MissionRepository>();
            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
            #endregion
            #region Localization
            services.AddLocalization(options =>
            {
                options.ResourcesPath = "Resources";
            });
            var supportedCultures = new List<CultureInfo>
            {
                new CultureInfo("tr-TR"),
                new CultureInfo("en-US"),
            };
            var MyOptions = new RequestLocalizationOptions()
            {
                DefaultRequestCulture = new RequestCulture(culture: "tr-TR", uiCulture: "tr-TR"),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures
            };
            MyOptions.RequestCultureProviders = new[]
            {
                new RouteDataRequestCultureProvider() { RouteDataStringKey = "lang", Options = MyOptions }
            };
            services.AddSingleton(MyOptions);

            #endregion



            services.AddMvc()
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
                .AddDataAnnotationsLocalization();

            #region Session

            services.AddHttpContextAccessor();
            services.AddDistributedMemoryCache();
            services.AddSession();
            #endregion

        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();


            app.UseSession();

            //app.UseStaticHttpContext();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{lang=tr-TR}/{controller=Home}/{action=Login}"
                );

            });


        }
    }
}
