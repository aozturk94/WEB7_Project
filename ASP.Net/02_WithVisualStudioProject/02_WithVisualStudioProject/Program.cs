using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_WithVisualStudioProject
{
    public class Program
    {
        //Aslýnda tm Asp.net Core uygulamalarý birer console uygulamasýdýr.
        //Doðal olarak uygulama çalýþmaya Program.cs dosyasý içindeki
        //Main metodu iele baþlar.
        public static void Main(string[] args)
        {
            //Burasý uygulamamýzýn baþlangýç noktasýdýr.
            //Tüm iþleyiþ bu noktada baþlýyor.
            //CreateHostBuilder metodu çaðrýlarak sunucumuza dair
            //tüm özellikler, konfigürasyonlar belirleniyor ve sonuç
            //buraya döndürülüyor. Dönen sunucu bilgileri ile uygulama önce Build(derleme)
            //sonra ise Run(çalýtýrma) ediliyor.

            CreateHostBuilder(args).Build().Run();
        }
        //CreateHostBuilder metodu sunucuyu ayaða kaldýrýrken, bir takým
        //konfigürasyonlara ihtiyaç duyar. Bu konfigürasyonlar Startup
        //classýndan alýr ve kullanýr.

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    //Default olarak oluþturulan bu yapýda, baþlangýç
                    //konfigürasyonlarý Startup adýndaki classta yer alýyor.
                    //Ancak bu isim mecburi bir isim deðildir.
                    webBuilder.UseStartup<Startup>();
                });
    }
}
