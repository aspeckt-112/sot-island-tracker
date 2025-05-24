using Microsoft.EntityFrameworkCore.Metadata.Builders;

using SotIslandTracker.Database.Entities;

namespace SotIslandTracker.Database.Configurations;

public class RegionConfiguration : BaseConfiguration<RegionEntity>
{
    public override void Configure(EntityTypeBuilder<RegionEntity> builder)
    {
        base.Configure(builder);

        builder.Property(r => r.Name)
            .IsRequired()
            .HasMaxLength(100);
        
        // Relation with Islands configured in the island entity configuration
    }
}