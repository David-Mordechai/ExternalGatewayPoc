using AutoMapper;
using ExternalGatewayPoc.Infrastructure.Dtos;

namespace ExternalGatewayPoc.Infrastructure.Mapping;

public class MessageMapper : Profile
{
    public MessageMapper()
    {
        CreateMap<ImportMessageDto, ExportMessageDto>()
            .ForMember(dest => dest.ExpMsgId, src => src.MapFrom(x => x.ImpMsgId))
            .ForMember(dest => dest.ExpMsgVersion, src => src.MapFrom(x => x.ImpMsgVersion))
            .ForMember(dest => dest.ExpMsgName, src => src.MapFrom(x => x.ImpMsgName))
            .ForMember(dest => dest.ExpMsgDescription, src => src.MapFrom(x => x.ImpMsgDescription));
    }
}