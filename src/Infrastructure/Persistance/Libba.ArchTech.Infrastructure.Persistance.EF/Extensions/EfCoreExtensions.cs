using Libba.ArchTech.Infrastructure.Persistance.EF.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Libba.ArchTech.Infrastructure.Persistance.EF.Extensions;

public static class EfCoreExtensions
{
    public static IServiceCollection AddEfCoreRegistration (this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ArchTechContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("PostgreSqlConnection")));

        return services;
    }
}
