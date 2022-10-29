using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PizzaWebApp.Model;
using PizzaWebApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace PizzaWebApp
{
    public class Startup
    {
        

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddControllers(); //for controller
            services.AddTransient<JsonFilePizzaService>(); //for Services
            services.AddTransient<StyleSheetService>();//for StyleSheet Service
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                //---add this for controller
                endpoints.MapControllers();

                //--------Jugari Way to Get API
                // endpoints.MapGet("/PizzaRecord", (context) =>
                //{
                //   IEnumerable<Pizza> pizzaRecord = app.ApplicationServices.GetService<JsonFilePizzaService>().getPizzaRecord();
                //   string newPizzaRecord = JsonSerializer.Serialize<IEnumerable<Pizza>>(pizzaRecord);
                //    return context.Response.WriteAsync(newPizzaRecord);
                // });
            });
        }
    }
}
