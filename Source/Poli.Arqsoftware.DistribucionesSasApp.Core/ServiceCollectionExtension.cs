using System;
namespace Poli.Arqsoftware.DistribucionesSasApp.Core
{
    using Microsoft.Extensions.DependencyInjection;
    using Poli.Arqsoftware.DistribucionesSasApp.Core.DataAccess;
    using Poli.Arqsoftware.DistribucionesSasApp.Core.Domain;
    using Poli.Arqsoftware.DistribucionesSasApp.Core.Repository;
    using System;
    using System.Collections.Generic;

    public static class ServiceCollectionExtension
    {
        public static void RegisterCoreComponents(this IServiceCollection services)
        {
            services.RegisterDataAccess();
            services.RegisterRepositories();
            services.RegisterDomains();
        }

        public static void RegisterDomains(this IServiceCollection services)
        {
            services.AddTransient<IPersonDomain, PersonDomain>();
        }

        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddTransient<IPersonRepository, PersonRepository>();
        }

        public static void RegisterDataAccess(this IServiceCollection services)
        {
            services.AddScoped<ISqlServer, SqlServer>();
        }
    }
}
