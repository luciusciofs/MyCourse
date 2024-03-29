using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MyCourseSdk3._1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options=>options.EnableEndpointRouting=false);
            
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            /*
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    string nome=context.Request.Query["nome"];
                    await context.Response.WriteAsync($"Hello {nome}!");
                });
            });
             app.UseMvc(routeBuilder =>
            {
                routeBuilder.MapRoute("default","{controller}/{action}/{id}");
            });
   */   
      
if (env.IsEnvironment("Development"))
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseRouting();
            
            app.UseMvc(routeBuilder =>
            {
                routeBuilder.MapRoute("default","{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}
