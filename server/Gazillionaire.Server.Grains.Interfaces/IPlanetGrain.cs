using Orleans;

namespace Gazillionaire.Server.Grains.Interfaces;

public interface IPlanetGrain : IGrainWithStringKey
{
    Task SetPlanetName(string name);
    Task<string> GetPlanetName();
}