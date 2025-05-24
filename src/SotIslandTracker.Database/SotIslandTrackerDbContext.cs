using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using SotIslandTracker.Database.Entities;

namespace SotIslandTracker.Database;

public class SotIslandTrackerDbContext : IdentityDbContext<UserEntity, UserRoleEntity, int>
{
    public SotIslandTrackerDbContext(DbContextOptions<SotIslandTrackerDbContext> options)
        : base(options)
    {
    }

    override protected void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(typeof(SotIslandTrackerDbContext).Assembly);
    }
}