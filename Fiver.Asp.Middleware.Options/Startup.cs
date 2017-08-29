using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Fiver.Asp.Middleware.Options
{
    public class Startup
    {
        public void ConfigureServices(
            IServiceCollection services)
        {
            //services.AddMessageFormatter(new MessageOptions
            //{
            //    Format = MessageFormat.Lower
            //});

            services.AddMessageFormatter(options =>
            {
                options.Format = MessageFormat.Upper;
            });
        }

        public void Configure(
            IApplicationBuilder app, 
            IHostingEnvironment env)
        {
            //app.UseGreeting(new GreetingOptions
            //{
            //    GreetAt = "Morning",
            //    GreetTo = "Tahir"
            //});

            app.UseGreeting(options =>
            {
                options.GreetAt = "Evening";
                options.GreetTo = "Naushad";
            });
        }
    }
}
