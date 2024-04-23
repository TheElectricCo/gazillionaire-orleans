using Microsoft.AspNetCore.Mvc;

namespace Gazillionaire.Server.Config;

[ApiController]
public abstract class ApiControllerBase : ControllerBase
{
    private IGrainFactory? _grainFactory;
    protected IGrainFactory GrainFactory => _grainFactory ??= HttpContext.RequestServices.GetRequiredService<IGrainFactory>();
}