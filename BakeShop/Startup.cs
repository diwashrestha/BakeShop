using BakeShop.Data;
using BakeShop.Data.interfaces;
using BakeShop.Data.mocks;
using BakeShop.Data.Models;
using BakeShop.Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace BakeShop
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        // EntryPoint for configuration data
        private IConfigurationRoot _configurationRoot;

        public Startup(IWebHostEnvironment hostingEnvironment)
        {
            _configurationRoot = new ConfigurationBuilder().SetBasePath(hostingEnvironment.ContentRootPath)
                .AddJsonFile("appsettings.json")
                .Build();
        }
        public void ConfigureServices(IServiceCollection services)
        {
            //Server configuration
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(_configurationRoot.GetConnectionString("DefaultConnection")));
            services.AddTransient<IBakeryItemRepository, BakeryItemRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => ShoppingCart.GetCart(sp));
            services.AddMvc(option => option.EnableEndpointRouting = false);

            services.AddMemoryCache(); ;
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseSession();
            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "categoryFilter", template: "BakeryItem/{action}/{category?}", defaults: new { Controller = "BakeryItem", action = "List" });
                routes.MapRoute("default", "{controller=Home}/{action=Index}/{Id?}");
            });
            DbInitializer.Seed(serviceProvider);
        }
    }
}
