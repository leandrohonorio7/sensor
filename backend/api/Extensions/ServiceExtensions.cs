using infra.context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace api.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlServeContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConn");
            services.AddDbContext<RepositoryContext>(options => options.UseSqlServer(connectionString));
        }
    }
}