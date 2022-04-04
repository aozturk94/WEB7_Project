using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_WithVisualStudioProject
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Uygulamada kullan�lacak olan service'lerin eklendi�i ya da bildirildi�i ya da  ayarland��� yerdir.
            //Service mod�l, k�t�phane gibi d���n�lebilir.
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {   
            //Bu metod uygulamada kullan�cak olan ara katman ya da
            //ara metodlar�n bildirildi�i ve ayarlar�n�n yap�ld��� yerdir.
            //�ok s�k�a MiddleWare olarak an�lacakt�r.
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Bu MiddleWare routing �zelliklerini kullanaca��m�z� belirtir.
            app.UseRouting();


            app.UseEndpoints(endpoints =>
            {
                //endpoints uygulamaya gelen isteklerin var��
                //noktas�n� ifade eden �ablon yap�s�d�r.
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
