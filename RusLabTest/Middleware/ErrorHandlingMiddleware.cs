using System.Net;
using System.Text.Json;

namespace RusLabTest.Middleware
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception error)
            {
                var response = context.Response;
                response.ContentType = "application/json";

                switch (error)
                {
                    case HttpRequestException e:
                        response.StatusCode = e.StatusCode.HasValue ? (int)e.StatusCode.Value : 500;
                        break;
                    default:
                        response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        break;
                }

                var result = JsonSerializer.Serialize(new { message = error?.Message });
                // Don't write anything in case of an error.
                // We don't have any standard message for now (TODO)
                // await response.WriteAsync(result);
            }
        }
    }
}