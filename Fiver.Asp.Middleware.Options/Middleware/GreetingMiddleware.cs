using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Fiver.Asp.Middleware.Options
{
    //public class GreetingMiddleware
    //{
    //    private readonly RequestDelegate next;
    //    private readonly GreetingOptions options;

    //    public GreetingMiddleware(
    //        RequestDelegate next,
    //        GreetingOptions options)
    //    {
    //        this.next = next;
    //        this.options = options;
    //    }

    //    public async Task Invoke(
    //        HttpContext context)
    //    {
    //        var message = $"Good {this.options.GreetAt} {this.options.GreetTo}";
    //        await context.Response.WriteAsync(message);
    //    }
    //}

    public class GreetingMiddleware
    {
        private readonly RequestDelegate next;
        private readonly GreetingOptions options;

        public GreetingMiddleware(
            RequestDelegate next,
            GreetingOptions options)
        {
            this.next = next;
            this.options = options;
        }

        public async Task Invoke(
            HttpContext context,
            IMessageService service)
        {
            var message = $"Good {this.options.GreetAt} {this.options.GreetTo}";
            var formatted = service.FormatMessage(message);
            await context.Response.WriteAsync(formatted);
        }
    }
}
