using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Primitives;

namespace MiddleWareSample
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
	        services.AddGeneralPractitionerAuthorization();
        }

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app)
        {
            app.UseIISPlatformHandler();

	        app.UseSomeMiddleware();

			app.UseGeneralPractitionerAuthorizationMiddleware();

			app.MapWhen(context =>
	        {
		        return context.Request.Query.ContainsKey("branch");
	        }, HandleBranch);

			app.Run(async (context) =>
			{
				await context.Response.WriteAsync("Hello World!");
			});
		}

	    private void HandleBranch(IApplicationBuilder app)
	    {
			app.Run(async (context) =>
			{
				await context.Response.WriteAsync("Branch used.");
			});
		}

	    // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
