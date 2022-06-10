using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airlines29
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        public static List<string> poltronasExistentesA = new List<string> { "A1", "A2", "A3", "A4", "A5", "A6" };
        public static List<string> poltronasExistentesB = new List<string> { "B1", "B2", "B3", "B4", "B5", "B6" };
        public static List<string> poltronasCompradas1 = new List<string> { "B1" };
        public static List<string> poltronasCompradas2 = new List<string> { };
        public static List<string> poltronasCompradas3 = new List<string> { "A1" };
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
