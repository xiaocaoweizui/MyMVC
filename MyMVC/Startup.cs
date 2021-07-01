using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MyMVC
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
            services.AddControllersWithViews();
            services.AddDirectoryBrowser();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseDirectoryBrowser();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //注册默认的路由
                endpoints.MapControllerRoute(
                    name: "Default",
                    // url的正则规则，去掉域名和端口后的地址进行匹配
                    pattern: "{controller}/{action}");

                ////注册默认的路由
                //endpoints.MapControllerRoute(
                //    name: "Home2",
                //    // url的正则规则，去掉域名和端口后的地址进行匹配
                //    pattern: "{controller}/{action}/{id}",
                //    defaults:new { controller="Home",action="Index"},
                //    constraints:new { id=@"d{2}"}
                // );

                ////路由模板方式
                //endpoints.MapControllerRoute(
                //   name: "Home",
                //   // url的正则规则，去掉域名和端口后的地址进行匹配
                //   pattern: "{controller=Home}/{action=index}/{id=0}");



                //endpoints.MapControllers();
            });
        }
    }
}
