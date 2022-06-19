namespace ExternalGatewayPoc.Core;

public interface IImporter
{
    void Subscribe(Action<string> action, CancellationToken cancellationToken);
}