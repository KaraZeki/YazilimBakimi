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

        //Configuration daki inject iþlemi appsettings.json kýlasýndaki bilgilere eriþmek için yazýlýr
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
                    HttpOnly = true, //scripler okunamaz güvenlik açýsýndan önemli
                    Name = "ShopApp.Securty.Cookie", //Cookie nin özel ismi
                    SameSite=SameSiteMode.Strict //Baþka bir kullanýcý bizim cookie yi alýp server a gönderemez. Csrf 
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
         
            app.UseAuthentication();//Identity iþlemi içindir
            app.UseMvc(routes =>
            {
               
            });

        }
    }
}
