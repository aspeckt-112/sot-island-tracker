using Microsoft.EntityFrameworkCore;

using SotIslandTracker.Database;

namespace SotIslandTracker.Web.Extensions;

internal static class WebApplicationExtensions
{
    internal static async Task MigrateDatabase(this IHost host)
    {
        IServiceScope scope = host.Services
            .GetRequiredService<IServiceScopeFactory>()
            .CreateScope();

        using (scope)
        {
            var dbContext = scope.ServiceProvider
                .GetRequiredService<SotIslandTrackerDbContext>();

            await dbContext.Database.MigrateAsync();
        }
    }
}