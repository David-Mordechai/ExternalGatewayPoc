namespace ExternalGatewayPoc.Infrastructure.Dtos;

public class ImportMessageDto
{
    public Guid ImpMsgId { get; set; }
    public string? ImpMsgVersion { get; set; }
    public string? ImpMsgName { get; set; }
    public string? ImpMsgDescription { get; set; }
}