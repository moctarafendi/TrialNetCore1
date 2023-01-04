using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using TrialNetCore1.IService;
using TrialNetCore1.Service;

namespace TrialNetCore1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddTransient<IBookRepository, BookRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});

            //ini untuk mendapatkan feedback ketika terjadi kesalahan. Gunakan ketika development saja tidak perlu untuk versi production.
            app.UseDeveloperExceptionPage();

            //digunakan untuk mendapatkan status request dari 400 sampai 599
            app.UseStatusCodePages();

            //aplikasi akan support untuk file2 static yang ditaruh di dalam folder wwwroot
            app.UseStaticFiles();

            //
            app.UseMvcWithDefaultRoute();
        }
    }
}
