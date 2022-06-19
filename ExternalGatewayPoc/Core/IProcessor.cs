namespace ExternalGatewayPoc.Core;

public interface IProcessor
{
    (bool Success, string ExportMessageAsJson) Process(string message);
}