using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Fiver.Asp.Middleware.Options
{
    public class Startup
    {
        //public void ConfigureServices(
        //    IServiceCollection services)
        //{
        //    services.AddMessageFormatter(new MessageOptions
        //    {
        //        Format = MessageFormat.Lower
        //    });
        //}

        public void ConfigureServices(
            IServiceCollection services)
        {
            services.AddMessageFormatter(options =>
            {
                options.Format = MessageFormat.Lower;
            });
        }

        //public void Configure(
        //    IApplicationBuilder app,
        //    IHostingEnvironment env)
        //{
        //    app.UseGreeting(new GreetingOptions
        //    {
        //        GreetAt = "Morning",
        //        GreetTo = "Tahir"
        //    });
        //}

        public void Configure(
            IApplicationBuilder app,
            IHostingEnvironment env)
        {
            app.UseGreeting(options =>
            {
                options.GreetAt = "Morning";
                options.GreetTo = "Tahir";
            });
        }
    }
}
