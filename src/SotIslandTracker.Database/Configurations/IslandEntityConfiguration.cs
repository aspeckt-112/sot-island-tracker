using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using SotIslandTracker.Database.Entities;

namespace SotIslandTracker.Database.Configurations;

public class IslandEntityConfiguration : BaseConfiguration<IslandEntity>
{
    public override void Configure(EntityTypeBuilder<IslandEntity> builder)
    {
        base.Configure(builder);

        builder.Property(i => i.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.HasOne(i => i.Region)
            .WithMany(r => r.Islands)
            .HasForeignKey(i => i.RegionId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}