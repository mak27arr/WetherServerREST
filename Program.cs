using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using WetherServer.Database.SQLite;
using WetherServer.Database.Clases;

namespace WetherServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UsersContecst userContecst = new UsersContecst();
            userContecst.Users.Add(new User());
            userContecst.SaveChanges();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
