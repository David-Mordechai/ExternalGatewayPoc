using ExternalGatewayPoc.Infrastructure.Dtos;

namespace ExternalGatewayPoc.Infrastructure.Actions.Interfaces;

public interface IFilterAction
{
    ImportMessageDto Filter(ImportMessageDto importMessage);
}