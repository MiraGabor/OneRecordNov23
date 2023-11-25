using MediatR;
using OneCheck.Application.Dtos.SheetsDtos;
using OneCheck.Application.Requests.Queries;
using OneRecord.Api.SDK.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCheck.Application.Handlers.Queries;
public class PostSheetRequestHandler : IRequestHandler<PostSheetRequest>
{
    public Task<Unit> Handle(PostSheetRequest request, CancellationToken cancellationToken)
    {
        var check = new Check();
        LoadingUnit unit = new LoadingUnit();
        var listOfCheck = new List<Check>();   
        listOfCheck.Add(FillCheckWithOriginPreparationSheetDto(request.Sheet.PreparationSheet));
        listOfCheck.Add(FillCheckWithOriginHandlingAgentSheetDto(request.Sheet.OriginHandlingAgentSheet));
        foreach (var item in request.Sheet.TransitSheets)
        {
            listOfCheck.Add(FillCheckWithInboundTransitItem(item.InboundTransitSheetModel));
            listOfCheck.Add(FillCheckWithOutboundTransitItem(item.OutboundTransitSheetModel));
        }
        listOfCheck.Add(FillCheckWithDestinationHandlingAgentItem(request.Sheet.DestinationHandlingAgentSheet));
        listOfCheck.Add(FillCheckWithDestinationConsigneeItem(request.Sheet.DestinationConsigneeSheet));
        return null;
    }

    private Check FillCheckWithOriginPreparationSheetDto(OriginPreparationSheetDto originPreparationSheetDto)
    {

        var check = new Check();
        check.Type.Add("cargo:Check");
        check.UsedTemplate.Name = "OriginPreparationSheetDto";
        check.UsedTemplate.Type = new List<string> { "cargo:CheckTemplate" };
        check.UsedTemplate.Questions.AddRange(new List<Question>
        {
            CreateQuestion(nameof(originPreparationSheetDto.Name),originPreparationSheetDto.Name),
            CreateQuestion(nameof(originPreparationSheetDto.Signature),originPreparationSheetDto.Signature),
            CreateQuestion(nameof(originPreparationSheetDto.TempSetting),originPreparationSheetDto.TempSetting.ToString()),
            CreateQuestion(nameof(originPreparationSheetDto.Time),originPreparationSheetDto.Time.ToString()),
            CreateQuestion(nameof(originPreparationSheetDto.Date),originPreparationSheetDto.Date.ToString()),
            CreateQuestion(nameof(originPreparationSheetDto.IsBatteryCharged),originPreparationSheetDto.IsBatteryCharged.ToString()),
            CreateQuestion(nameof(originPreparationSheetDto.Routing), String.Join(",", originPreparationSheetDto.Routing)),
            CreateQuestion(nameof(originPreparationSheetDto.IsContainerDamaged), originPreparationSheetDto.IsContainerDamaged.ToString()),
            CreateQuestion(nameof(originPreparationSheetDto.SealNumber), originPreparationSheetDto.SealNumber),
            CreateQuestion(nameof(originPreparationSheetDto.ULDNumber), originPreparationSheetDto.ULDNumber),
            CreateQuestion(nameof(originPreparationSheetDto.ULDPrecooledTemp), originPreparationSheetDto.ULDPrecooledTemp.ToString()),
            CreateQuestion(nameof(originPreparationSheetDto.GoodsPrecooledAtTemps), originPreparationSheetDto.GoodsPrecooledAtTemps.ToString()),
            CreateQuestion(nameof(originPreparationSheetDto.AcceptedTempRange), originPreparationSheetDto.AcceptedTempRange),
            CreateQuestion(nameof(originPreparationSheetDto.AWBNumber), originPreparationSheetDto.AWBNumber.ToString()),
            CreateQuestion(nameof(originPreparationSheetDto.CheckSheetId), originPreparationSheetDto.CheckSheetId.ToString()),
            CreateQuestion(nameof(originPreparationSheetDto.EmergencyPhone), originPreparationSheetDto.EmergencyPhone),
        });
        return check;
    }

    private Check FillCheckWithOriginHandlingAgentSheetDto(OriginHandlingAgentSheetDto originHandlingAgentSheetDto)
    {

        var check = new Check();
        check.Type.Add("cargo:Check");
        check.UsedTemplate.Name = "OriginHandlingAgentSheetDto";
        check.UsedTemplate.Type = new List<string> { "cargo:CheckTemplate" };
        check.UsedTemplate.Questions.AddRange(new List<Question>
        {
            CreateQuestion(nameof(originHandlingAgentSheetDto.Name),originHandlingAgentSheetDto.Name),
            CreateQuestion(nameof(originHandlingAgentSheetDto.Signature),originHandlingAgentSheetDto.Signature),
            CreateQuestion(nameof(originHandlingAgentSheetDto.Is5AdaptersPresents),originHandlingAgentSheetDto.Is5AdaptersPresents.ToString()),
            CreateQuestion(nameof(originHandlingAgentSheetDto.Time),originHandlingAgentSheetDto.Time.ToString()),
            CreateQuestion(nameof(originHandlingAgentSheetDto.Date),originHandlingAgentSheetDto.Date.ToString()),
            CreateQuestion(nameof(originHandlingAgentSheetDto.IsAlert),originHandlingAgentSheetDto.IsAlert.ToString()),
            CreateQuestion(nameof(originHandlingAgentSheetDto.AlertDisplayed), originHandlingAgentSheetDto.AlertDisplayed),
            CreateQuestion(nameof(originHandlingAgentSheetDto.IsContainerDamaged), originHandlingAgentSheetDto.IsContainerDamaged.ToString()),
            CreateQuestion(nameof(originHandlingAgentSheetDto.SealNumber), originHandlingAgentSheetDto.SealNumber),
            CreateQuestion(nameof(originHandlingAgentSheetDto.DisplayedTemp), originHandlingAgentSheetDto.DisplayedTemp.ToString()),
            CreateQuestion(nameof(originHandlingAgentSheetDto.CheckSheetId), originHandlingAgentSheetDto.CheckSheetId.ToString()),
        });
        return check;
    }

    private Check FillCheckWithInboundTransitItem(InboundTransitSheetDto inboundTransitSheetDto)
    {

        var check = new Check();
        check.Type.Add("cargo:Check");
        check.UsedTemplate.Name = "InboundTransitSheetDto";
        check.UsedTemplate.Type = new List<string> { "cargo:CheckTemplate" };
        check.UsedTemplate.Questions.AddRange(new List<Question>
        {
            CreateQuestion(nameof(inboundTransitSheetDto.Name),inboundTransitSheetDto.Name),
            CreateQuestion(nameof(inboundTransitSheetDto.Signature),inboundTransitSheetDto.Signature),
            CreateQuestion(nameof(inboundTransitSheetDto.BlueLight),inboundTransitSheetDto.BlueLight.ToString()),
            CreateQuestion(nameof(inboundTransitSheetDto.Time),inboundTransitSheetDto.Time.ToString()),
            CreateQuestion(nameof(inboundTransitSheetDto.Date),inboundTransitSheetDto.Date.ToString()),
            CreateQuestion(nameof(inboundTransitSheetDto.IsContainerOperating),inboundTransitSheetDto.IsContainerOperating.ToString()),
            CreateQuestion(nameof(inboundTransitSheetDto.DisplayedTemp), inboundTransitSheetDto.DisplayedTemp.ToString()),
            CreateQuestion(nameof(inboundTransitSheetDto.IsContainerDamaged), inboundTransitSheetDto.IsContainerDamaged.ToString()),
            CreateQuestion(nameof(inboundTransitSheetDto.SealNumber), inboundTransitSheetDto.SealNumber),
            CreateQuestion(nameof(inboundTransitSheetDto.CheckSheetId), inboundTransitSheetDto.CheckSheetId.ToString()),
            CreateQuestion(nameof(inboundTransitSheetDto.BatteryStatusInPercent), inboundTransitSheetDto.BatteryStatusInPercent.ToString()),
            CreateQuestion(nameof(inboundTransitSheetDto.InboundCheckAirportCode), inboundTransitSheetDto.InboundCheckAirportCode.ToString()),

        });
        return check;
    }

    private Check FillCheckWithOutboundTransitItem(OutboundTransitSheetDto outboundTransitSheetDto)
    {

        var check = new Check();
        check.Type.Add("cargo:Check");
        check.UsedTemplate.Name = "OutboundTransitSheetDto";
        check.UsedTemplate.Type = new List<string> { "cargo:CheckTemplate" };
        check.UsedTemplate.Questions.AddRange(new List<Question>
        {
           CreateQuestion(nameof(outboundTransitSheetDto.Name),outboundTransitSheetDto.Name),
            CreateQuestion(nameof(outboundTransitSheetDto.Signature),outboundTransitSheetDto.Signature),
            CreateQuestion(nameof(outboundTransitSheetDto.BlueLight),outboundTransitSheetDto.BlueLight.ToString()),
            CreateQuestion(nameof(outboundTransitSheetDto.Time),outboundTransitSheetDto.Time.ToString()),
            CreateQuestion(nameof(outboundTransitSheetDto.Date),outboundTransitSheetDto.Date.ToString()),
            CreateQuestion(nameof(outboundTransitSheetDto.IsContainerOperating),outboundTransitSheetDto.IsContainerOperating.ToString()),
            CreateQuestion(nameof(outboundTransitSheetDto.DisplayedTemp), outboundTransitSheetDto.DisplayedTemp.ToString()),
            CreateQuestion(nameof(outboundTransitSheetDto.IsContainerDamaged), outboundTransitSheetDto.IsContainerDamaged.ToString()),
            CreateQuestion(nameof(outboundTransitSheetDto.SealNumber), outboundTransitSheetDto.SealNumber),
            CreateQuestion(nameof(outboundTransitSheetDto.CheckSheetId), outboundTransitSheetDto.CheckSheetId.ToString()),
            CreateQuestion(nameof(outboundTransitSheetDto.BatteryStatusInPercent), outboundTransitSheetDto.BatteryStatusInPercent.ToString()),
            CreateQuestion(nameof(outboundTransitSheetDto.OutboundCheckAirportCode), outboundTransitSheetDto.OutboundCheckAirportCode.ToString()),
        });
        return check;
    }


    private Check FillCheckWithDestinationHandlingAgentItem(DestinationHandlingAgentSheetDto dDestinationHandlingAgentSheetDto)
    {

        var check = new Check();
        check.Type.Add("cargo:Check");
        check.UsedTemplate.Name = "DestinationHandlingAgentSheetDto";
        check.UsedTemplate.Type = new List<string> { "cargo:CheckTemplate" };
        check.UsedTemplate.Questions.AddRange(new List<Question>
        {
            CreateQuestion(nameof(dDestinationHandlingAgentSheetDto.Name),dDestinationHandlingAgentSheetDto.Name),
            CreateQuestion(nameof(dDestinationHandlingAgentSheetDto.Signature),dDestinationHandlingAgentSheetDto.Signature),
            CreateQuestion(nameof(dDestinationHandlingAgentSheetDto.Time),dDestinationHandlingAgentSheetDto.Time.ToString()),
            CreateQuestion(nameof(dDestinationHandlingAgentSheetDto.Date),dDestinationHandlingAgentSheetDto.Date.ToString()),
            CreateQuestion(nameof(dDestinationHandlingAgentSheetDto.IsContainerOperating),dDestinationHandlingAgentSheetDto.IsContainerOperating.ToString()),
            CreateQuestion(nameof(dDestinationHandlingAgentSheetDto.DisplayedTemp), dDestinationHandlingAgentSheetDto.DisplayedTemp.ToString()),
            CreateQuestion(nameof(dDestinationHandlingAgentSheetDto.IsContainerDamaged), dDestinationHandlingAgentSheetDto.IsContainerDamaged.ToString()),
            CreateQuestion(nameof(dDestinationHandlingAgentSheetDto.SealNumber), dDestinationHandlingAgentSheetDto.SealNumber),
            CreateQuestion(nameof(dDestinationHandlingAgentSheetDto.CheckSheetId), dDestinationHandlingAgentSheetDto.CheckSheetId.ToString()),
            CreateQuestion(nameof(dDestinationHandlingAgentSheetDto.BatteryStatusInPercent), dDestinationHandlingAgentSheetDto.BatteryStatusInPercent.ToString()),
            CreateQuestion(nameof(dDestinationHandlingAgentSheetDto.BlueLight), dDestinationHandlingAgentSheetDto.BlueLight.ToString()),
            CreateQuestion(nameof(dDestinationHandlingAgentSheetDto.IsAlarmDisplayed), dDestinationHandlingAgentSheetDto.IsAlarmDisplayed.ToString()),
            CreateQuestion(nameof(dDestinationHandlingAgentSheetDto.SetTempOnDisplay), dDestinationHandlingAgentSheetDto.SetTempOnDisplay.ToString()),
        });
        return check;
    }
    private Check FillCheckWithDestinationConsigneeItem(DestinationConsigneeSheetDto destinationConsigneeSheetDto)
    {

        var check = new Check();
        check.Type.Add("cargo:Check");
        check.UsedTemplate.Name = "DestinationConsigneeSheetDto";
        check.UsedTemplate.Type = new List<string> { "cargo:CheckTemplate" };
        check.UsedTemplate.Questions.AddRange(new List<Question>
        {
            CreateQuestion(nameof(destinationConsigneeSheetDto.Name),destinationConsigneeSheetDto.Name),
            CreateQuestion(nameof(destinationConsigneeSheetDto.Signature),destinationConsigneeSheetDto.Signature),
            CreateQuestion(nameof(destinationConsigneeSheetDto.Time),destinationConsigneeSheetDto.Time.ToString()),
            CreateQuestion(nameof(destinationConsigneeSheetDto.Date),destinationConsigneeSheetDto.Date.ToString()),
            CreateQuestion(nameof(destinationConsigneeSheetDto.IsContainerOperating),destinationConsigneeSheetDto.IsContainerOperating.ToString()),
            CreateQuestion(nameof(destinationConsigneeSheetDto.DisplayedTemp), destinationConsigneeSheetDto.DisplayedTemp.ToString()),
            CreateQuestion(nameof(destinationConsigneeSheetDto.IsContainerDamaged), destinationConsigneeSheetDto.IsContainerDamaged.ToString()),
            CreateQuestion(nameof(destinationConsigneeSheetDto.SealNumber), destinationConsigneeSheetDto.SealNumber),
            CreateQuestion(nameof(destinationConsigneeSheetDto.CheckSheetId), destinationConsigneeSheetDto.CheckSheetId.ToString()),
            CreateQuestion(nameof(destinationConsigneeSheetDto.BatteryStatusInPercent), destinationConsigneeSheetDto.BatteryStatusInPercent.ToString()),
            CreateQuestion(nameof(destinationConsigneeSheetDto.RecipientName), destinationConsigneeSheetDto.RecipientName.ToString()),
            CreateQuestion(nameof(destinationConsigneeSheetDto.RecipientSignature), destinationConsigneeSheetDto.RecipientName.ToString()),
            CreateQuestion(nameof(destinationConsigneeSheetDto.Is5AdaptersPresents), destinationConsigneeSheetDto.Is5AdaptersPresents.ToString()),
        });
        return check;
    }

    private Question CreateQuestion(string propertyName, string value)
    {
       return new Question
        {
            Type = new List<string> { "cargo:Question" },
            HttpsCargoshortText = propertyName,
            HttpsCargoanswer = new Answer
            {
                Type = new List<string> { "cargo:Answer" },
                Text = value,
            }
        };
    }
}
