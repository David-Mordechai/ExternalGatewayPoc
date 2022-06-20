using System.Text.Json;
using ExternalGatewayPoc.Core;
using ExternalGatewayPoc.Infrastructure.Dtos;

namespace ExternalGatewayPoc.Infrastructure;

public class Importer : IImporter
{
    private readonly ILogger<Importer> _logger;

    public Importer(ILogger<Importer> logger)
    {
        _logger = logger;
    }

    public void Subscribe(Action<string> action, CancellationToken cancellationToken)
    {
        var importMessage = new ImportMessageDto
        {
            ImpMsgId = Guid.NewGuid(),
            ImpMsgVersion = "1.0.0",
            ImpMsgName = "FirstMessage",
            ImpMsgDescription = "My very first message"
        };

        var importMessageAsJson = JsonSerializer.Serialize(importMessage);
        _logger.LogInformation("Imported new message: {message}", importMessageAsJson);
        action?.Invoke(importMessageAsJson);
    }
}