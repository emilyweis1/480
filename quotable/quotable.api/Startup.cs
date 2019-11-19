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

        /// <summary>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {

            // create the datacontext to be used by the database-backed Quotable number generator
            // - the name of the database file is in the connection string
            services.AddDbContext<QuotableDbContext>(options => options.UseSqlite(@"Data Source=quotable.db;"));

            // the controller is expecting to be provided an instance of QuotableNumberGenerator
            //services.AddSingleton<QuotableNumberGenerator, NaiveQuotableNumberGenerator>();
            // services.AddSingleton<QuotableeNumberGenerator, DatabaseQuotableNumberGenerator>();
            services.AddScoped<QuotableNumberGenerator, DatabaseQuotableNumberGenerator>();

            services.AddHttpContextAccessor();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
