using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using SotIslandTracker.Database;
using SotIslandTracker.Database.Entities;
using SotIslandTracker.Migrations;

namespace SotIslandTracker.Web.Extensions;

internal static class ServiceCollectionExtensions
{
    internal static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        // Set in user secrets when running locally
        string connectionString = configuration.GetConnectionString("SotIslandTrackerContext") ??
                                  throw new InvalidOperationException(
                                      "Connection string 'SotIslandTrackerContext' not found.");

        services.AddDbContextPool<SotIslandTrackerDbContext>(options =>
            options.UseNpgsql(connectionString,
                npgsqlOptions =>
                {
                    npgsqlOptions.SetPostgresVersion(17, 5);
                    npgsqlOptions.MigrationsAssembly(
                        typeof(Marker).Assembly.GetName().Name);
                }));

        services.AddDatabaseDeveloperPageExceptionFilter();

        return services;
    }

    internal static IServiceCollection AddAspNetIdentity(this IServiceCollection services)
    {
        services
            .AddIdentity<UserEntity, UserRoleEntity>()
            .AddEntityFrameworkStores<SotIslandTrackerDbContext>();

        return services;
    }
}