using cle_spring_2021_courses.Models;
using cle_spring_2021_courses.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_spring_2021_courses
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSession();
            services.AddMvc();
            
            services.AddDbContext<UniversityContext>();
            //services.AddScoped<IRepository<Course>, CourseRepository>();
            //services.AddScoped<IRepository<Instructor>, InstructorRepository>();
            //services.AddScoped<IRepository<Student>, StudentRespository>();
            services.AddScoped(typeof(IRepository<Course>), typeof(Repository<Course>));
            services.AddScoped(typeof(IRepository<Instructor>), typeof(Repository<Instructor>));
            services.AddScoped(typeof(IRepository<Student>), typeof(Repository<Student>));
            services.AddScoped(typeof(IRepository<User>), typeof(Repository<User>));

            services.AddControllersWithViews().AddRazorRuntimeCompilation();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Course}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
               
            });
        }
    }
}
