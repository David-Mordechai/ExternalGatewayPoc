using System.Text.Json;
using AutoMapper;
using ExternalGatewayPoc.Core;
using ExternalGatewayPoc.Infrastructure.Actions.Interfaces;
using ExternalGatewayPoc.Infrastructure.Dtos;

namespace ExternalGatewayPoc.Infrastructure;

public class Processor : IProcessor
{
    private readonly ILogger<Processor> _logger;
    private readonly IMapper _mapper;
    private readonly IFilterAction _filterAction;

    public Processor(ILogger<Processor> logger, IMapper mapper, IFilterAction filterAction)
    {
        _logger = logger;
        _mapper = mapper;
        _filterAction = filterAction;
    }

    public (bool Success, string ExportMessageAsJson) Process(string message)
    {
        try
        {
            _logger.LogInformation("Processing new message: {message}", message);
            var importMessage = JsonSerializer.Deserialize<ImportMessageDto>(message);
            if (importMessage == null)
                throw new Exception("Fail to Deserialize message");

            _filterAction.Filter(importMessage);

            var exportMessage = _mapper.Map<ExportMessageDto>(importMessage);

            var exportMessageAsJson = JsonSerializer.Serialize(exportMessage);
            return (Success: true, exportMessageAsJson);
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Fail to process message: {message}", message);
            return (Success: false, string.Empty);
        }
    }
}