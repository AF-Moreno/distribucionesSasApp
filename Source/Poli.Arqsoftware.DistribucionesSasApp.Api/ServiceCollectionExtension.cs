namespace Poli.Arqsoftware.DistribucionesSasApp.Api
{
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.OpenApi.Models;

    public static class ServiceCollectionExtension
    {

        public static void AddSwaggerDocumentConfing(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "distribuciones-service", Version = "v1" });
            });
        }
    }
}
