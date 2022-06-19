using System.Text.Json;
using ExternalGatewayPoc.Core;
using ExternalGatewayPoc.Infrastructure.Dtos;

namespace ExternalGatewayPoc.Infrastructure;

public class Importer : IImporter
{
    public void Subscribe(Action<string> action, CancellationToken cancellationToken)
    {
        var importMessage = new ImportMessageDto
        {
            ImpMsgId = new Guid(),
            ImpMsgVersion = "1.0.0",
            ImpMsgName = "FirstMessage",
            ImpMsgDescription = "My very first message"
        };

        var importMessageAsJson = JsonSerializer.Serialize(importMessage);
        action?.Invoke(importMessageAsJson);
    }
}