using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace AspNetCore{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Use(async (context, next) => {
                    context.Response.Headers.Add("MIDDLEWARE", "Aprendendo");
                    await context.Response.WriteAsync("Outro item");

                    await next.Invoke();
            });

            app.Run(context =>context.Response.WriteAsync("oo"));
        }
    }
}