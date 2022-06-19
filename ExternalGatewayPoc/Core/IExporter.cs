namespace ExternalGatewayPoc.Core;

public interface IExporter
{
    void Export(string message);
}