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
            //Bu service'i ekleyerek uygulamam�n MVC mimarisinde olaca��n� belirtmi� olduk.
            //Dolay�s�yla bu uygulamaya gelen bir request(istek) kar��labilir haldedir.
            //Kar��layacak olan �ey Controller'd�r.
            //Gelen Request'e kar��l�k d�nd�rece�imiz response bir HTML sayfa
            //olaca�� i�in Views'i de kullanaca��m�z� belirtmi� olduk.
            //*Model ise bir SERV�CE DE��LD�R! Bu y�zden burada onu eklemek gibi bir i�lem yapm�yoruz.
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Gelen requestlerin rotas� bu middleware taraf�ndan belirlenecektir.
            //Rotalama sistemi burada kullan�lmaya ba�lar.
            app.UseRouting();

            //Bu yap� i�erisindeki en kritik middlewarelerden birisi budur: endpoints! VARI� NOKTASI
            //Bir request geldi�inde onu anlamland�racak ve gitmesi gereken yere y�nlendirecek yap�dad�r.
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
