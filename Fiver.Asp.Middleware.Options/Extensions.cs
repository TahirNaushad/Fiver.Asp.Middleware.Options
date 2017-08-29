using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Fiver.Asp.Middleware.Options
{
    public static class Extensions
    {
        #region " Middleware "

        public static IApplicationBuilder UseGreeting(
            this IApplicationBuilder app, GreetingOptions options)
        {
            return app.UseMiddleware<GreetingMiddleware>(options);
        }

        public static IApplicationBuilder UseGreeting(
            this IApplicationBuilder app, Action<GreetingOptions> configureOptions)
        {
            var options = new GreetingOptions();
            configureOptions(options);

            return app.UseMiddleware<GreetingMiddleware>(options);
        }

        #endregion

        #region " Services "

        public static IServiceCollection AddMessageFormatter(
            this IServiceCollection services, MessageOptions options)
        {
            return services.AddScoped<IMessageService>(factory =>
            {
                return new MessageService(options);
            });
        }

        public static IServiceCollection AddMessageFormatter(
            this IServiceCollection services, Action<MessageOptions> configureOptions)
        {
            var options = new MessageOptions();
            configureOptions(options);

            return services.AddScoped<IMessageService>(factory =>
            {
                return new MessageService(options);
            });
        }

        #endregion
    }
}
