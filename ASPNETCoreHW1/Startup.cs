using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCoreHW1.Models;

namespace ASPNETCoreHW1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        //註冊服務
        public void ConfigureServices(IServiceCollection services)
        {
            // using Microsoft.EntityFrameworkCore;
            services.AddDbContext<ContosouniversityContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("CotosouniversityConnection")));
            services.AddScoped<ContosouniversityContextProcedures>();
            services.AddControllers().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ASPNETCoreHW1", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //註冊middle ware
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //app.UseDeveloperExceptionPage(); //錯誤頁面
                app.UseExceptionHandler("/Error");
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ASPNETCoreHW1 v1"));
                
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseHttpsRedirection(); //80自動轉443

            app.UseRouting();

            app.UseAuthorization(); //授權

            //設定端點對外
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
