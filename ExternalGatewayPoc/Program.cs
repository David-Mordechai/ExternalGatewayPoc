using ExternalGatewayPoc;
using ExternalGatewayPoc.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructureLayer();

builder.Services.AddHostedService<Worker>();

var app = builder.Build();

app.Run();