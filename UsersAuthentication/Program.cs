using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace  UsersAuthentication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    var p = System.Reflection.Assembly.GetEntryAssembly().Location;
                    p = p.Substring(0, p.LastIndexOf(@"\") + 1);

                    webBuilder.UseContentRoot(p);
                    webBuilder.UseStartup<Startup>();

                });
    }
}
