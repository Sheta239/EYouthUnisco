using EYouthUnisco.API.Helpers;

namespace EYouthUnisco.API.Extensions
{
    public static class SwaggerAuthorizeExtensions
    {
        public static IApplicationBuilder UseSwaggerAuthorized(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<SwaggerAuthorizedMiddleware>();
        }
    }
}
