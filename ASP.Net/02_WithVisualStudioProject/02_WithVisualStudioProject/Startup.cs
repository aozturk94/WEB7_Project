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
            //Uygulamada kullanýlacak olan service'lerin eklendiði ya da bildirildiði ya da  ayarlandýðý yerdir.
            //Service modül, kütüphane gibi düþünülebilir.
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {   
            //Bu metod uygulamada kullanýcak olan ara katman ya da
            //ara metodlarýn bildirildiði ve ayarlarýnýn yapýldýðý yerdir.
            //Çok sýkça MiddleWare olarak anýlacaktýr.
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Bu MiddleWare routing özelliklerini kullanacaðýmýzý belirtir.
            app.UseRouting();


            app.UseEndpoints(endpoints =>
            {
                //endpoints uygulamaya gelen isteklerin varýþ
                //noktasýný ifade eden þablon yapýsýdýr.
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
