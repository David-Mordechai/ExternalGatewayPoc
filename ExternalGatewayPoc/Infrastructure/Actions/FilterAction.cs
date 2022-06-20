using ExternalGatewayPoc.Infrastructure.Actions.Interfaces;
using ExternalGatewayPoc.Infrastructure.Dtos;

namespace ExternalGatewayPoc.Infrastructure.Actions;

public class FilterAction : IFilterAction
{
    private readonly ILogger<FilterAction> _logger;

    public FilterAction(ILogger<FilterAction> logger)
    {
        _logger = logger;
    }

    public ImportMessageDto Filter(ImportMessageDto importMessage)
    {
        _logger.LogInformation("Filtering new message, messageId: {messageId}", importMessage.ImpMsgId);
        return importMessage;
    }
}