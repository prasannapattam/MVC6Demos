using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Framework.ConfigurationModel;
using Microsoft.AspNet.Hosting;

namespace MvcWebApi
{
    public class Startup
    {
        public IConfiguration Configuration;

        public Startup(IHostingEnvironment env)
        {
            Configuration = new Configuration()
                            .AddJsonFile("Config.json");

        }

        //rest of the code
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "Home", action = "Index" });
            });
        }
    }
}
