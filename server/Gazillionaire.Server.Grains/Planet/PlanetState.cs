using Orleans;

namespace Gazillionaire.Server.Grains.Planet;

[GenerateSerializer, Alias("PlanetState")]
public sealed record class PlanetState
{
    [Id(0)] public string Name { get; set; } = "";
}