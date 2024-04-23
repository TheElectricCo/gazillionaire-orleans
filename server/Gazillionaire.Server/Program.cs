var builder = WebApplication.CreateBuilder(args);

builder.Host.UseOrleans(static siloBuilder =>
{
    siloBuilder.UseLocalhostClustering();
    siloBuilder.AddMemoryGrainStorage("Gazillionaire");
});

builder.Services.AddControllers();

var app = builder.Build();

app
    .UseRouting()
    .UseEndpoints(ep =>
    {
        ep.MapControllers();
    });

app.Run();