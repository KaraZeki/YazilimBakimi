using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ShopApp.Business.Abstract;
using ShopApp.Business.Concrete;
using ShopApp.DataAccess.Abstract;
using ShopApp.DataAccess.Conrete.EfCore;
using ShopApp.DataAccess.Conrete.Memory;
using ShopApp.WebUI.Middlewares;

namespace ShopApp.WebUI
{
    public class Startup
    {

        //Configuration daki inject i�lemi appsettings.json k�las�ndaki bilgilere eri�mek i�in yaz�l�r
       public IConfiguration   Configuration { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)  
        {
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie = new CookieBuilder
                {
                    HttpOnly = true, //scripler okunamaz g�venlik a��s�ndan �nemli
                    Name = "ShopApp.Securty.Cookie", //Cookie nin �zel ismi
                    SameSite=SameSiteMode.Strict //Ba�ka bir kullan�c� bizim cookie yi al�p server a g�nderemez. Csrf 
                };
            });

          
            //send e mail services
            services.AddMvc(options => options.EnableEndpointRouting = false);

        }

        

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) 
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
           
            app.UseStaticFiles();
            app.CustomStaticFiles();
         
            app.UseAuthentication();//Identity i�lemi i�indir
            app.UseMvc(routes =>
            {
               
            });

        }
    }
}
