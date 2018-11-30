﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InteriorShoppe.Data;
using InteriorShoppe.Models;
using InteriorShoppe.Models.Handlers;
using InteriorShoppe.Models.Interfaces;
using InteriorShoppe.Models.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InteriorShoppe
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            //var builder = new ConfigurationBuilder().AddEnvironmentVariables();
            //builder.AddUserSecrets<Startup>();
            Configuration = configuration;

        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 3;
                options.Password.RequireLowercase = true;
            }

            )
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddDbContext<InteriorShoppeDbContext>(options =>
                 options.UseSqlServer(Configuration.GetConnectionString("ShoppeProductionDB")));

            services.AddDbContext<ApplicationDbContext>(options =>
                 options.UseSqlServer(Configuration.GetConnectionString("IdentityProductionDB")));

            services.AddTransient<IInventory, InventoryServices>();
            services.AddTransient<IBasket, BasketService>();

            services.AddAuthorization(options =>
            {
                options.AddPolicy("EduEmailPolicy", policy => policy.Requirements.Add(new EduEmailRequirementHandler()));
            });

            services.AddScoped<IEmailSender, EmailSender>();
        }

    

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                name: "default",
                template: "{controller=Home}/{action=Index}/{id?}");
            });

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }
    }
}
