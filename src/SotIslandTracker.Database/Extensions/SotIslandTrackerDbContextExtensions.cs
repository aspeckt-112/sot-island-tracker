using SotIslandTracker.Database.Entities;

namespace SotIslandTracker.Database.Extensions;

public static class SotIslandTrackerDbContextExtensions
{
    public static void Seed(this SotIslandTrackerDbContext context)
    {
        var (shoresOfPlenty, wilds, ancientIsles, devilsRoar) = (
            new RegionEntity { Name = "The Shores of Plenty" },
            new RegionEntity { Name = "The Wilds" },
            new RegionEntity { Name = "The Ancient Isles" },
            new RegionEntity { Name = "The Devil's Roar" }
        );

        if (!context.Regions.Any())
        {
            context.Regions.AddRange(shoresOfPlenty, wilds, ancientIsles, devilsRoar);
            context.SaveChanges();
        }

        if (!context.Islands.Any())
        {
            context.Islands.AddRange(
                new IslandEntity
                {
                    Name = "Keel Haul Fort",
                    Region = shoresOfPlenty,
                    IsFortress = true,
                    IsLarge = false
                },
                new IslandEntity
                {
                    Name = "Hidden Spring Keep",
                    Region = shoresOfPlenty,
                    IsFortress = true,
                    IsLarge = false
                },
                new IslandEntity
                {
                    Name = "Sailor's Knot Stronghold",
                    Region = shoresOfPlenty,
                    IsFortress = true,
                    IsLarge = false
                },
                new IslandEntity
                {
                    Name = "Cannon Cove",
                    Region = shoresOfPlenty,
                    IsFortress = false,
                    IsLarge = true
                },
                new IslandEntity
                {
                    Name = "Crescent Isle",
                    Region = shoresOfPlenty,
                    IsFortress = false,
                    IsLarge = true
                },
                new IslandEntity
                {
                    Name = "Lone Cove",
                    Region = shoresOfPlenty,
                    IsFortress = false,
                    IsLarge = true
                },
                new IslandEntity
                {
                    Name = "Mermaid's Hideaway",
                    Region = shoresOfPlenty,
                    IsFortress = false,
                    IsLarge = true
                },
                new IslandEntity
                {
                    Name = "Sailor's Bounty",
                    Region = shoresOfPlenty,
                    IsFortress = false,
                    IsLarge = true
                },
                new IslandEntity
                {
                    Name = "Smugglers' Bay",
                    Region = shoresOfPlenty,
                    IsFortress = false,
                    IsLarge = true
                },
                new IslandEntity
                {
                    Name = "Wanderer's Refuge",
                    Region = shoresOfPlenty,
                    IsFortress = false,
                    IsLarge = true
                },
                new IslandEntity
                {
                    Name = "Boulder Cay",
                    Region = shoresOfPlenty,
                    IsFortress = false,
                    IsLarge = false
                },
                new IslandEntity
                {
                    Name = "Lagoon of Whispers",
                    Region = shoresOfPlenty,
                    IsFortress = false,
                    IsLarge = false
                },
                new IslandEntity
                {
                    Name = "Lonely Isle",
                    Region = shoresOfPlenty,
                    IsFortress = false,
                    IsLarge = false
                },
                new IslandEntity
                {
                    Name = "Picaroon Palms",
                    Region = shoresOfPlenty,
                    IsFortress = false,
                    IsLarge = false
                },
                new IslandEntity
                {
                    Name = "Rapier Cay",
                    Region = shoresOfPlenty,
                    IsFortress = false,
                    IsLarge = false
                },
                new IslandEntity
                {
                    Name = "Rum Runner Isle",
                    Region = shoresOfPlenty,
                    IsFortress = false,
                    IsLarge = false
                },
                new IslandEntity
                {
                    Name = "Salty Sands",
                    Region = shoresOfPlenty,
                    IsFortress = false,
                    IsLarge = false
                },
                new IslandEntity
                {
                    Name = "Sandy Shallows",
                    Region = shoresOfPlenty,
                    IsFortress = false,
                    IsLarge = false
                },
                new IslandEntity
                {
                    Name = "Sea Dog's Rest",
                    Region = shoresOfPlenty,
                    IsFortress = false,
                    IsLarge = false
                },
                new IslandEntity
                {
                    Name = "Twin Groves",
                    Region = shoresOfPlenty,
                    IsFortress = false,
                    IsLarge = false
                }
            );

            context.SaveChanges();
        }
    }

    public static Task SeedAsync(this SotIslandTrackerDbContext context)
    {
        return Task.Run(() => Seed(context));
    }
}