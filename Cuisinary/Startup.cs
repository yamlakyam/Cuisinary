using Cuisinary.Data;
using Cuisinary.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cuisinary
{
    public class Startup
    {
        private IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddSingleton<IGreeter, Greeter>();

            services.AddDbContext<CuisinaryDbContext>(
                options => options.UseSqlServer(_configuration.GetConnectionString("Cuisinary")));
            services.AddScoped<IRestaurantData, SqlRestaurantData>();

            services.AddMvc(options=>options.EnableEndpointRouting=false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, 
                              IWebHostEnvironment env, 
                              IGreeter greeter) //creating and injecting own Greeting service
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc(ConfigureRoutes); 
            //app.UseMvc(obj=>obj.MapRoute("Default",
            //    "{controller=Home}/{action=Index}/{Id?}"));
            app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        var greeting = greeter.GetMessageOfTheDay();
            //        //await context.Response.WriteAsync("Hello World!");
            //        await context.Response.WriteAsync(greeting + env.EnvironmentName);
            //    });
            //});

        }

        private void ConfigureRoutes(IRouteBuilder obj)
        {
            obj.MapRoute("Default", 
                "{controller=Home}/{action=Index}/{Id?}");
        }
    }
}
