using AutoMapper;
using OneCheck.Api.Dtos.SheetsDtos;
using OneCheck.Domain.Model.SheetModels;

namespace OneCheck.Api.MapperConfiguration;

public class MapperProfile :Profile
{
    public MapperProfile() 
    { 
        CreateMap<CheckSheetModel, CheckSheetDto>()
            .ReverseMap();
        CreateMap<DestinationConsigneeSheetModel, DestinationConsigneeSheetDto>()
            .ReverseMap();
        CreateMap<DestinationHandlingAgentSheetModel, DestinationHandlingAgentSheetDto>()
            .ReverseMap();
        CreateMap<OriginHandlingAgentSheetModel, OriginHandlingAgentSheetDto>()
            .ReverseMap();
        CreateMap<OriginPreparationSheetModel, OriginPreparationSheetDto>()
            .ReverseMap();
        CreateMap<OutboundTransitSheetModel, OutboundTransitSheetDto>()
            .ReverseMap();
        CreateMap<TransitCheckSheetModel, TransitCheckSheetDto>()
            .ReverseMap();
        CreateMap<BlueLightEnumModel, BlueLightEnumDto>()
             .ReverseMap();

    }
}
