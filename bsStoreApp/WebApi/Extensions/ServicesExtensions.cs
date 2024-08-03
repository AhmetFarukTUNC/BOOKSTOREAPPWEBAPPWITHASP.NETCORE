using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using Repositories.EF;
using Repositories.EFCore;
using Services;
using Services.Contract;
using System.Runtime.CompilerServices;

namespace WebApi.Extensions
{
    public static class ServicesExtensions
    {

        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
          services.AddDbContext<RepositoryContext>(
              options =>
                    options.UseSqlServer(configuration.GetConnectionString("sqlConnection"))

        );
        }

        public static void ConfigurationRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManger, RepositoryManager>();


        public static void ConfigurationServiceManager(this IServiceCollection services) =>
            services.AddScoped<IServiceManager, ServiceManager>();


    }
}
