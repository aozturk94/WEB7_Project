using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Core_02
{
    public class Program
    {
        //DonNet FrameWork ile EF projeleri yaarken sihirbaz yard�m� ile 
        //projelerimize EF ekleyeibliyorduk. Ancak, Core projelerinde bu i�i sihirbaz yard�m�yla
        //Yapabilece�imiz bir yol yok. Bu i�i terminal ekran�nda komutlar yazara ger�ekle�tirece�iz.
        public static void Main(string[] args)
        {
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
