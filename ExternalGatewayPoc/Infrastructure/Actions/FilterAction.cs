using ExternalGatewayPoc.Infrastructure.Actions.Interfaces;
using ExternalGatewayPoc.Infrastructure.Dtos;

namespace ExternalGatewayPoc.Infrastructure.Actions;

public class FilterAction : IFilterAction
{
    public ImportMessageDto Filter(ImportMessageDto importMessage)
    {
        return importMessage;
    }
}