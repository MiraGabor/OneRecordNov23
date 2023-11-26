using AutoMapper;
using OneRecord.Api.SDK.Model;
using OneRecord.Api.SDK.Response;

namespace OneCheck.Api.MapperConfiguration;

public class MapperProfile :Profile
{
    public MapperProfile() 
    { 
        CreateMap<Check, CheckResponse>()
            .ReverseMap();
        CreateMap<CheckTemplate, CheckTemplateResponse>()
            .ReverseMap();
        CreateMap<LogisticsObject, LogisticsObjectReponse>()
            .ReverseMap();
    }
}
