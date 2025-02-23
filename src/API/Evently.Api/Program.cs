using Evently.Api.Extensions;
using Evently.Modules.Events.Infrastructure;
using Scalar.AspNetCore;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddEventsModule(builder.Configuration);

WebApplication app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference(o =>
    {
        o.Servers = [new ScalarServer("https://localhost:5001")];
    });
    app.ApplyMigrations();
}

EventsModule.MapEndpoints(app);

await app.RunAsync();
