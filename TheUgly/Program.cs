using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace TheUgly
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // spot me
            // DefaultEndpointsProtocol=https;AccountName=astssg;AccountKey=/+hUySQRxiNlNiWkeaSr305cxOY4IGoFfmGp3tto39boTCzdrPeOcnanQ4UQ225bToPGN7Kx9LyHHGlltW89Rg==;EndpointSuffix=core.windows.net
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}
