using ExternalGatewayPoc.Core;

namespace ExternalGatewayPoc.Infrastructure;

public class Exporter : IExporter
{
    private readonly ILogger<Exporter> _logger;

    public Exporter(ILogger<Exporter> logger)
    {
        _logger = logger;
    }

    public void Export(string message)
    {
        _logger.LogInformation("Exporting message: {message}", message);
    }
}