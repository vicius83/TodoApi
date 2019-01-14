using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace TodoApi
{
#pragma warning disable CS1591
    public class Program
    {
        private static IConfiguration config;

        public static void Main(string[] args)
        {
            IConfigurationRoot config = new ConfigurationBuilder().AddCommandLine(args).Build();
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseConfiguration(config);
    }
#pragma warning restore CS1591
}
