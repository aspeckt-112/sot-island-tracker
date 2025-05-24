namespace SotIslandTracker.Database.Entities;

public class RegionEntity : BaseEntity
{
    public required string Name { get; set; }

    public ICollection<IslandEntity> Islands { get; set; } = [];
}