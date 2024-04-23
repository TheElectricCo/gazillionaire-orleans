using Gazillionaire.Server.Grains.Interfaces;
using Orleans;
using Orleans.Runtime;

namespace Gazillionaire.Server.Grains.Planet;

public sealed class PlanetGrain([PersistentState("planet", "Gazillionaire")] IPersistentState<PlanetState> state)
    : Grain, IPlanetGrain
{
    public Task SetPlanetName(string name)
    {
        state.State = new PlanetState { Name = name };
        return state.WriteStateAsync();
    }

    public Task<string> GetPlanetName()
        => Task.FromResult(state.State.Name);
}