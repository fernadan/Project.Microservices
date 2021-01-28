using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Docs.Swagger
{
    public static class SwaggerConfig
    {
        public static void ConfigureSwaggerDoc(this IServiceCollection services, string description)
        {
            services.AddOpenApiDocument(config =>
            {
                config.Version = "v1";
                config.AllowReferencesWithProperties = true;
                config.Title = "Documentação da API: " + Assembly.GetEntryAssembly().GetName().Name;
                config.Description = description;
            });
        }

        public static void ConfigureSwaggerUI(this IApplicationBuilder app)
        {
            app.UseOpenApi();

            app.UseSwaggerUi3(config => config.TransformToExternalPath = (internalUiRoute, request) =>
            {
                config.Path = "/swagger";
                if (internalUiRoute.StartsWith("/") == true && internalUiRoute.StartsWith(request.PathBase) == false)
                    return request.PathBase + internalUiRoute;
                else
                    return internalUiRoute;
            });
        }
    }
}
