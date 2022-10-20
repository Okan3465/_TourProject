using DataAccessLayer.Concrate.EFCore;
using EntityLayer;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourProject.Models;

namespace TourProject
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddDbContext<TurContext>(options => options.UseSqlite("Data Source=VanDb"));
            //services.AddScoped
            //services.AddSingleton
            //services.AddTransient
            //services.AddCors
            //services.AddLogging

            services.AddDbContext<TurContext>();  //identity kütüphanesinden sonra 1. iþlem
            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<TurContext>().AddErrorDescriber<CustomIdentityValidator>().AddEntityFrameworkStores<TurContext>() ;
            //identity kütüphanesinden sonra 2. iþlem
            //AddErrorDescriber Parola iþlemleri için daha sonra uygulanan iþlemdir(drs31)


            services.AddControllersWithViews();
            /*  services.AddSession(); *///oturum ekleme iþlemi

           
            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()       //identity kütüphanesinden sonra 3. iþlem olarak proje seviyesinde authantice iþlemi yapýlýyor
                .RequireAuthenticatedUser()
                .Build();

                config.Filters.Add(new AuthorizeFilter(policy));
            });

            services.AddMvc();  //identity kütüphanesinden sonra 4. iþlem

            //Hata sayfalarýnýn önüne geçebilmek için bu komutlar verildi 
            services.AddAuthentication  (CookieAuthenticationDefaults.AuthenticationScheme) //Hata sayfalarýnýn önüne geçebilmek için bu komutlar verildi 
                .AddCookie(x =>
                {
                    x.LoginPath = "/Login/SignIn";
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                SeedDatabase.Seed();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //app.UseStatusCodePages(); //sayfada sadece hata olduðunu gösterir
            app.UseStatusCodePagesWithReExecute("/ErrorPage/Error1", "?code={0}");  //sayfada görsel þeklinde hata mesajý verdim
            app.UseHttpsRedirection();
            app.UseStaticFiles();
          /*  app.UseSession(); */ //oturum ekleme iþlemi için yapýlan iþlem 
            app.UseAuthentication();
            //identity kütüphanesinden sonra 5. iþlem
            //sisteme otantike olma iþlemi için 

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseEndpoints(endpoints =>   //Burasý Area için kullanýlan bir endpointtir
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
