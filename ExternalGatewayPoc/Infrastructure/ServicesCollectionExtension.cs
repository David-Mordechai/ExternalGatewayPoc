using System.Reflection;
using ExternalGatewayPoc.Core;
using ExternalGatewayPoc.Infrastructure.Actions;
using ExternalGatewayPoc.Infrastructure.Actions.Interfaces;

namespace ExternalGatewayPoc.Infrastructure;

public static class ServicesCollectionExtension
{
    public static void AddInfrastructureLayer(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        
        services.AddSingleton<IImporter, Importer>();
        services.AddSingleton<IProcessor, Processor>();
        services.AddSingleton<IExporter, Exporter>();
        
        services.AddSingleton<IFilterAction, FilterAction>();
    }
}