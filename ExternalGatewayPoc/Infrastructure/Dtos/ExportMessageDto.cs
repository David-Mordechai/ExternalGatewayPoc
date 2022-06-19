namespace ExternalGatewayPoc.Infrastructure.Dtos;

public class ExportMessageDto
{
    public Guid ExpMsgId { get; set; }
    public string? ExpMsgVersion { get; set; }
    public string? ExpMsgName { get; set; }
    public string? ExpMsgDescription { get; set; }
}