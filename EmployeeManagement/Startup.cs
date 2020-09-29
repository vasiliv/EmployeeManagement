using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace EmployeeManagement
{
    public class Startup
    {
        private IConfiguration _config;
        public Startup(IConfiguration config)
        {
            _config = config;        
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILogger <Startup> logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Use(async (context, next)  =>
            {
                //await context.Response.WriteAsync(_config["MyKey"]);
                //await context.Response.WriteAsync("Hello from first middleware");
                logger.LogInformation("Middleware1: incoming request");
                await next();
                logger.LogInformation("Middleware1: outgoing response");
            });
            app.Use(async (context, next) =>
            {
                logger.LogInformation("Middleware2: incoming request");
                await next();
                logger.LogInformation("Middleware2: outgoing response");
            });
            app.Run(async (context) =>
            {
                //await context.Response.WriteAsync(_config["MyKey"]);
                //await context.Response.WriteAsync("Hello from second middleware");
                await context.Response.WriteAsync("Middleware3: request handled and response produced");
                logger.LogInformation("Middleware3: request handled and response produced");
            });
        }
    }
}
