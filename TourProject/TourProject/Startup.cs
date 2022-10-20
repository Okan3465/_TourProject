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

            services.AddDbContext<TurContext>();  //identity k�t�phanesinden sonra 1. i�lem
            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<TurContext>().AddErrorDescriber<CustomIdentityValidator>().AddEntityFrameworkStores<TurContext>() ;
            //identity k�t�phanesinden sonra 2. i�lem
            //AddErrorDescriber Parola i�lemleri i�in daha sonra uygulanan i�lemdir(drs31)


            services.AddControllersWithViews();
            /*  services.AddSession(); *///oturum ekleme i�lemi

           
            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()       //identity k�t�phanesinden sonra 3. i�lem olarak proje seviyesinde authantice i�lemi yap�l�yor
                .RequireAuthenticatedUser()
                .Build();

                config.Filters.Add(new AuthorizeFilter(policy));
            });

            services.AddMvc();  //identity k�t�phanesinden sonra 4. i�lem

            //Hata sayfalar�n�n �n�ne ge�ebilmek i�in bu komutlar verildi 
            services.AddAuthentication  (CookieAuthenticationDefaults.AuthenticationScheme) //Hata sayfalar�n�n �n�ne ge�ebilmek i�in bu komutlar verildi 
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

            //app.UseStatusCodePages(); //sayfada sadece hata oldu�unu g�sterir
            app.UseStatusCodePagesWithReExecute("/ErrorPage/Error1", "?code={0}");  //sayfada g�rsel �eklinde hata mesaj� verdim
            app.UseHttpsRedirection();
            app.UseStaticFiles();
          /*  app.UseSession(); */ //oturum ekleme i�lemi i�in yap�lan i�lem 
            app.UseAuthentication();
            //identity k�t�phanesinden sonra 5. i�lem
            //sisteme otantike olma i�lemi i�in 

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseEndpoints(endpoints =>   //Buras� Area i�in kullan�lan bir endpointtir
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
