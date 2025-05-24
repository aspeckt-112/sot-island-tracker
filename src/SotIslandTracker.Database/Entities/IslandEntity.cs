namespace SotIslandTracker.Database.Entities;

public class IslandEntity : BaseEntity
{
    public int RegionId { get; set; }

    public RegionEntity Region { get; set; } = null!;

    public required string Name { get; set; }
    
    public required bool IsFortress { get; set; }
    
    public required bool IsLarge { get; set; }
}