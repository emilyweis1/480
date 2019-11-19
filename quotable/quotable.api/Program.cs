using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace quotable.api
{

    /// <summary>
    /// Class: Program creates a web host builder
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main: instantiates and runs the web host builder
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Takes in a string param to use as the default builder
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return WebHost
                        .CreateDefaultBuilder(args)
                        .ConfigureLogging(logBuilder =>
                        {
                            logBuilder.ClearProviders(); // removes all providers from LoggerFactory
                            logBuilder.AddConsole();
                            logBuilder.AddTraceSource("Information, Trace"); // Add Trace listener provider
                            logBuilder.SetMinimumLevel(LogLevel.Trace);
                            //logBuilder.AddTraceSource("Information, ActivityTracing"); // Add Trace listener provider
                        })
                        .UseStartup<Startup>();
        }

        /// <summary>
        /// second webhost builder
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IWebHostBuilder CreateWebHostBuilder2(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
        }

    }
}
