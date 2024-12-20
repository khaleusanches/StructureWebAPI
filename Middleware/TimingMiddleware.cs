
namespace StructureWebAPI.Middleware
{
    public class TimingMiddleware : IMiddleware
    {
        private readonly ILogger<TimingMiddleware> _logger;
        public TimingMiddleware(ILogger<TimingMiddleware> logger)
        {
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                _logger.LogInformation("teasteando");
                await next(context);
                _logger.LogInformation("teasteando depois");
            }
            catch (Exception ex)
            {
                await context.Response.WriteAsync("Error");
            }
        }
    }
}
