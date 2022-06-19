using ExternalGatewayPoc.Core;

namespace ExternalGatewayPoc;

public class Worker : BackgroundService
{
    private readonly IImporter _importer;
    private readonly IProcessor _processor;
    private readonly IExporter _exporter;

    public Worker(IImporter importer, IProcessor processor, IExporter exporter)
    {
        _importer = importer;
        _processor = processor;
        _exporter = exporter;
    }

    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _importer.Subscribe(message =>
        {
            var (success, exportMessageAsJson) = _processor.Process(message);
            if (success)
                _exporter.Export(exportMessageAsJson);
        }, stoppingToken);
        
        return Task.CompletedTask;
    }
}