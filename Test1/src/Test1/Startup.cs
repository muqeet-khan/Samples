using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.Extensions.DependencyInjection;
using Test1.Services;

namespace Test1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<ServerDetailsService>();
            services.AddScoped<RequestDetailsService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app,IHostingEnvironment hosting)
        {
            app.UseGlenMiddleware();

            app.UseIISPlatformHandler();

            app.UseDeveloperExceptionPage();

            //app.Map("/thomas", (pipelineBuilder) =>
            //{
            //    pipelineBuilder.Run(async (context) =>
            //    {
            //        var headerVal = context.Response.Headers.GetCommaSeparatedValues("Server");
            //        if (headerVal.Length > 0)
            //        {
            //            context.Response.Headers.Remove("Server");
            //            context.Response.Headers.Add("Server", "Thomas");
            //        }

            //        await context.Response.WriteAsync("My Name is Thomas!");
            //    });
            //});

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Development!");
            //});

            //app.UseMvcWithDefaultRoute();

            app.UseMvc(config =>
           {
               config.MapRoute("default", "{controller=Main}/{action=Index}/{id?}");
           });


        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
