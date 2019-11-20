using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using quotable.core;
using Microsoft.EntityFrameworkCore;

namespace quotable.api
{
    /// <summary>
    /// instantiates the startup for all of the configurations
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// stes global configuration to passed in config
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        /// <summary>
        /// Configure the services for the application.
        /// </summary>
        /// <param name="services">The collection of service.</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            // setup to use a sqlite database
            services.AddDbContext<QuotableContext>(options => options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));
        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app">The application builder</param>
        /// <param name="env">The hosting environment</param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();

            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<QuotableContext>();
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                PopulateDatabase(context);
            }
        }

        private static void PopulateDatabase(QuotableContext context)
        {
            var author1 = new Author()
            {
                FirstName = "Dr",
                LastName = "Seuss"
            };
            var author2 = new Author()
            {
                FirstName = "Mr",
                LastName = "Spock"
            };
            var author3 = new Author()
            {
                FirstName = "Mr",
                LastName = "Tuvok"
            };

            var document1 = new Document();
            document1.Title = "Green Eggs and Ham";

            var document2 = new Document();
            document2.Title = "Vulcan, A Primer";

            var document3 = new Document();
            document3.Title = "Green Eggs and Vulcans";

            var da1 = new DocumentAuthor() { Document = document1, Author = author1 };
            var da2 = new DocumentAuthor() { Document = document2, Author = author2 };
            var da3 = new DocumentAuthor() { Document = document3, Author = author1 };
            var da4 = new DocumentAuthor() { Document = document3, Author = author2 };
            var da5 = new DocumentAuthor() { Document = document3, Author = author3 };

            context.AddRange(da1, da2, da3, da4, da5);

            context.SaveChanges();
        }

    }
}
