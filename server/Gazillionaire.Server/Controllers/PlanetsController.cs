using Gazillionaire.Server.Commands;
using Gazillionaire.Server.Config;
using Gazillionaire.Server.Grains.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Gazillionaire.Server.Controllers;

[Route("api/planets")]
public class PlanetsController : ApiControllerBase
{
    [HttpPost("")]
    public async Task<string> CreatePlanet([FromBody] CreatePlanetCommand command)
    {
        var id = Guid.NewGuid().ToString("N");
        var planet = GrainFactory.GetGrain<IPlanetGrain>(id);

        await planet.SetPlanetName(command.Name);
        return id;
    }
    
    [HttpGet("{id}")]
    public Task<string> GetPlanet([FromRoute] string id)
    {
        var planet = GrainFactory.GetGrain<IPlanetGrain>(id);
        return planet.GetPlanetName();
    }
}