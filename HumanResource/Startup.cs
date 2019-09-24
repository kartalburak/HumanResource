using HumanResource.DataAccess;
using HumanResource.DataAccess.Interfaces;
using HumanResource.DataAccess.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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
            services.AddDbContextPool<HumanResourceContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("HumanResourceDbContext")));

            services.AddScoped<IEmployee, EmployeeRepository>();
            services.AddScoped<IDepartment, DepartmentRepository>();



            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            //app.UseMvcWithDefaultRoute();


            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}"
                );
               
            });


        }
    }
}
