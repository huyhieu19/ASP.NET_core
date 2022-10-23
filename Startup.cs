using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp02.middlenware;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ASP02
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            /*
                Phương thức ConfigureServices cho phép truy cập đến các dịch vụ, dependency được Inject vào
                Webhost. Hoặc bạn cũng có thể đưa thêm các dependency tại đây.
            */
        }

        // IHostingEnvironment  env cho phép truy cập các biến môi trường, thư mục nguồn, thư mục file.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // if (env.IsDevelopment())
            // {
            //     app.UseDeveloperExceptionPage();
            // }

            // app.UseRouting();


            // app.UseEndpoints(endpoints =>
            // {
            //     endpoints.MapGet("/", async context =>
            //     {
            //         await context.Response.WriteAsync("Hello World!");
            //     });
            // });
            app.UseStaticFiles();
            // app.UseFirstmiddleware();
            // app.UseSecondmiddleware();

            app.UseRouting(); //EndpointRoutingMiddleware

            app.UseEndpoints((endpoints) =>
            {
                endpoints.MapGet("/about.html", async (context) =>
                {
                    await context.Response.WriteAsync("Trang gioi thieu");
                });

                endpoints.MapGet("/home.html", async (context) =>
                {
                    await context.Response.WriteAsync("Trang chu");
                });

            });




            // terminate middleware m1
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("\nXin chao ASP Net core");
            });
        }
    }
}