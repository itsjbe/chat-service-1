using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace chat_service_1
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
        }

        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            var serverAddressesFeature = app.ServerFeatures.Get<IServerAddressesFeature>();

            app.UseStaticFiles();

            app.Run(async context =>
                    {
                        context.Response.ContentType = "text/html";
                        await context.Response
                                     .WriteAsync("<p>Hosted by Kestrel</p>");

                        if (serverAddressesFeature != null)
                        {
                            await context.Response
                                         .WriteAsync("<p>Listening on the following addresses: " +
                                                     string.Join(", ", serverAddressesFeature.Addresses) +
                                                     "</p>");
                        }

                        await context.Response.WriteAsync($"<p>Request URL: {context.Request.GetDisplayUrl()}<p>");
                    });
        }
    }
}
