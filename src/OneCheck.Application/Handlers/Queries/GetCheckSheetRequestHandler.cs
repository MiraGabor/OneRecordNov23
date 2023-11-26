using AutoMapper;
using MediatR;
using Neone.ServiceClient;
using OneCheck.Application.Dtos.SheetsDtos;
using OneCheck.Application.Requests.Queries;
using OneRecord.Api.SDK.Model;
using OneRecord.Api.SDK.Response;

namespace OneCheck.Application.Handlers.Queries;

public class GetCheckSheetRequestHandler : IRequestHandler<GetSheetRequest, SheetDto>
{
    private readonly IClient _client;
    private readonly IMapper _mapper;

    public GetCheckSheetRequestHandler(IClient client)
    {
        _client = client;
        _mapper = new Mapper(new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Check, CheckResponse>()
                .ReverseMap();
            cfg.CreateMap<CheckTemplate, CheckTemplateResponse>()
                .ReverseMap();
            cfg.CreateMap<LogisticsObject, LogisticsObjectReponse>()
                .ReverseMap();
        }
        ));
    }

    public async Task<SheetDto> Handle(GetSheetRequest request, CancellationToken cancellationToken)
    {

        var checksResponses = await _client.GetChecks(request.Id);
        
        //map here checkresponse to check
        var checks = _mapper.Map<List<Check>>(checksResponses);
        
        return new SheetDto
        {
            OriginHandlingAgentSheet = ConvertFromCheckToOriginHandlingAgentSheetDto(checks.FirstOrDefault(x => x.UsedTemplate.Name == "OriginHandlingAgentSheetDto")),
            PreparationSheet = ConvertFromCheckToOriginPreparationSheetDto(checks.FirstOrDefault(x => x.UsedTemplate.Name == "OriginPreparationSheetDto")),
            DestinationConsigneeSheet = ConvertFromCheckToDestinationConsigneeSheetDto(checks.FirstOrDefault(x => x.UsedTemplate.Name == "DestinationConsigneeSheetDto")),
            DestinationHandlingAgentSheet = ConvertFromCheckToDestinationHandlingAgentSheetDto(checks.FirstOrDefault(x => x.UsedTemplate.Name == "DestinationHandlingAgentSheetDto")),
            TransitSheets = new List<TransitSheetDto>
            {
                new TransitSheetDto
                {
                    InboundTransitSheetModel = ConvertFromCheckToInboundTransitSheetDto(checks.FirstOrDefault(x => x.UsedTemplate.Name == "InboundTransitSheetDto")),
                    OutboundTransitSheetModel = ConvertFromCheckToOutboundTransitSheetDto(checks.FirstOrDefault(x => x.UsedTemplate.Name == "OutboundTransitSheetDto"))
                }
            }
        };
    }

    private OriginPreparationSheetDto ConvertFromCheckToOriginPreparationSheetDto(Check check)
    {
        return new OriginPreparationSheetDto
        {
            Name = check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("Name")).Answer.Text,
            SealNumber = check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("SealNumber")).Answer.Text,
            Signature = check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("Signature")).Answer.Text,
            AcceptedTempRange = check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("AcceptedTempRange")).Answer.Text,
            EmergencyPhone = check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("EmergencyPhone")).Answer.Text,
            IsBatteryCharged = Boolean.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("IsBatteryCharged")).Answer.Text),
            IsContainerDamaged = Boolean.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("IsContainerDamaged")).Answer.Text),
            ULDNumber = check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("ULDNumber")).Answer.Text,
            Routing = check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("Routing")).Answer.Text.Split(",").ToList(),
            Time = TimeOnly.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("Time")).Answer.Text),
            Date = DateOnly.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("Date")).Answer.Text),
            CheckSheetId = Guid.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("CheckSheetId")).Answer.Text),
            ULDPrecooledTemp = int.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("ULDNumber")).Answer.Text),
            BatteryStatusInPercent = int.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("BatteryStatusInPercent")).Answer.Text),
            GoodsPrecooledAtTemps = int.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("GoodsPrecooledAtTemps")).Answer.Text),
            TempSetting = int.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("TempSetting")).Answer.Text),
            AWBNumber = int.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("AWBNumber")).Answer.Text),

        };
    }

    private OriginHandlingAgentSheetDto ConvertFromCheckToOriginHandlingAgentSheetDto(Check check)
    {
        return new OriginHandlingAgentSheetDto
        {
            Name = check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("Name")).Answer.Text,
            SealNumber = check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("SealNumber")).Answer.Text,
            Signature = check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("Signature")).Answer.Text,
            IsContainerDamaged = Boolean.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("IsContainerDamaged")).Answer.Text),
            Time = TimeOnly.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("Time")).Answer.Text),
            Date = DateOnly.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("Date")).Answer.Text),
            CheckSheetId = Guid.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("CheckSheetId")).Answer.Text),
            BatteryStatusInPercent = int.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("BatteryStatusInPercent")).Answer.Text),
            AlertDisplayed = (check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("AlertDisplayed")).Answer.Text),
            SetTempOnDisplay = int.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("SetTempOnDisplay")).Answer.Text),
            DisplayedTemp = int.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("DisplayedTemp")).Answer.Text),
            Is5AdaptersPresents = Boolean.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("Is5AdaptersPresents")).Answer.Text),
            IsAlert = Boolean.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("IsAlert")).Answer.Text),
            BlueLight = Enum.Parse<BlueLightEnumDto>(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("BlueLight")).Answer.Text),
            IsContainerOperating = Boolean.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("IsContainerOperating")).Answer.Text),
            
        };
    }

    private InboundTransitSheetDto ConvertFromCheckToInboundTransitSheetDto(Check check)
    {
        return new InboundTransitSheetDto
        {
            Name = check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("Name")).Answer.Text,
            SealNumber = check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("SealNumber")).Answer.Text,
            Signature = check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("Signature")).Answer.Text,
            IsContainerDamaged = Boolean.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("IsContainerDamaged")).Answer.Text),
            Time = TimeOnly.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("Time")).Answer.Text),
            Date = DateOnly.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("Date")).Answer.Text),
            CheckSheetId = Guid.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("CheckSheetId")).Answer.Text),
            BatteryStatusInPercent = int.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("BatteryStatusInPercent")).Answer.Text),
            DisplayedTemp = int.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("DisplayedTemp")).Answer.Text),
            IsContainerOperating = Boolean.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("IsContainerOperating")).Answer.Text),
            BlueLight = Enum.Parse<BlueLightEnumDto>(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("BlueLight")).Answer.Text),
            InboundCheckAirportCode = check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("InboundCheckAirportCode")).Answer.Text,
            IsAlarmDisplayed = Boolean.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("IsAlarmDisplayed")).Answer.Text),
        };
    }
    private OutboundTransitSheetDto ConvertFromCheckToOutboundTransitSheetDto(Check check)
    {
        return new OutboundTransitSheetDto
        {
            Name = check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("Name")).Answer.Text,
            SealNumber = check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("SealNumber")).Answer.Text,
            Signature = check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("Signature")).Answer.Text,
            IsContainerDamaged = Boolean.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("IsContainerDamaged")).Answer.Text),
            Time = TimeOnly.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("Time")).Answer.Text),
            Date = DateOnly.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("Date")).Answer.Text),
            CheckSheetId = Guid.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("CheckSheetId")).Answer.Text),
            BatteryStatusInPercent = int.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("BatteryStatusInPercent")).Answer.Text),
            DisplayedTemp = int.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("DisplayedTemp")).Answer.Text),
            IsContainerOperating = Boolean.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("IsContainerOperating")).Answer.Text),
            BlueLight = Enum.Parse<BlueLightEnumDto>(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("BlueLight")).Answer.Text),
            OutboundCheckAirportCode = check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("OutboundCheckAirportCode")).Answer.Text,
            IsAlarmDisplayed = Boolean.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("IsAlarmDisplayed")).Answer.Text),
        };
    }

    private DestinationHandlingAgentSheetDto ConvertFromCheckToDestinationHandlingAgentSheetDto(Check check)
    {
        return new DestinationHandlingAgentSheetDto
        {
            Name = check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("Name")).Answer.Text,
            SealNumber = check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("SealNumber")).Answer.Text,
            Signature = check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("Signature")).Answer.Text,
            IsContainerDamaged = Boolean.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("IsContainerDamaged")).Answer.Text),
            Time = TimeOnly.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("Time")).Answer.Text),
            Date = DateOnly.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("Date")).Answer.Text),
            CheckSheetId = Guid.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("CheckSheetId")).Answer.Text),
            BatteryStatusInPercent = int.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("BatteryStatusInPercent")).Answer.Text),
            DisplayedTemp = int.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("DisplayedTemp")).Answer.Text),
            IsContainerOperating = Boolean.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("IsContainerOperating")).Answer.Text),
            BlueLight = Enum.Parse<BlueLightEnumDto>(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("BlueLight")).Answer.Text),
            InboundCheckAirportCode = check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("OutboundCheckAirportCode")).Answer.Text,
            IsAlarmDisplayed = Boolean.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("IsAlarmDisplayed")).Answer.Text),
            SetTempOnDisplay = int.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("SetTempOnDisplay")).Answer.Text),
        };
    }

    private DestinationConsigneeSheetDto ConvertFromCheckToDestinationConsigneeSheetDto(Check check)
    {
        return new DestinationConsigneeSheetDto
        {
            Name = check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("Name")).Answer.Text,
            SealNumber = check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("SealNumber")).Answer.Text,
            Signature = check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("Signature")).Answer.Text,
            IsContainerDamaged = Boolean.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("IsContainerDamaged")).Answer.Text),
            Time = TimeOnly.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("Time")).Answer.Text),
            Date = DateOnly.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("Date")).Answer.Text),
            CheckSheetId = Guid.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("CheckSheetId")).Answer.Text),
            BatteryStatusInPercent = int.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("BatteryStatusInPercent")).Answer.Text),
            DisplayedTemp = int.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("DisplayedTemp")).Answer.Text),
            IsContainerOperating = Boolean.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("IsContainerOperating")).Answer.Text),
            RecipientSignature = check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("RecipientSignature")).Answer.Text,
            Is5AdaptersPresents = Boolean.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("Is5AdaptersPresents")).Answer.Text),
            RecipientName = check.UsedTemplate.Questions.FirstOrDefault(x => x.AnswerOptionsText.Equals("RecipientName")).Answer.Text
        };
    }
}