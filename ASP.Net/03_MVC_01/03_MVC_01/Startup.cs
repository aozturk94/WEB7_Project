using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_MVC_01
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Bu service'i ekleyerek uygulamamýn MVC mimarisinde olacaðýný belirtmiþ olduk.
            //Dolayýsýyla bu uygulamaya gelen bir request(istek) karþýlabilir haldedir.
            //Karþýlayacak olan þey Controller'dýr.
            //Gelen Request'e karþýlýk döndüreceðimiz response bir HTML sayfa
            //olacaðý için Views'i de kullanacaðýmýzý belirtmiþ olduk.
            //*Model ise bir SERVÝCE DEÐÝLDÝR! Bu yüzden burada onu eklemek gibi bir iþlem yapmýyoruz.
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Gelen requestlerin rotasý bu middleware tarafýndan belirlenecektir.
            //Rotalama sistemi burada kullanýlmaya baþlar.
            app.UseRouting();

            //Bu yapý içerisindeki en kritik middlewarelerden birisi budur: endpoints! VARIÞ NOKTASI
            //Bir request geldiðinde onu anlamlandýracak ve gitmesi gereken yere yönlendirecek yapýdadýr.
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                //abc.com
                //abc.com/product
                //abc.com/product/index
                //abc.com/product/getCategories
            });
        }
    }
}
