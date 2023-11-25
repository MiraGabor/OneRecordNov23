using MediatR;
using OneCheck.Application.Dtos;
using OneCheck.Application.Dtos.SheetsDtos;
using OneCheck.Application.Requests.Queries;
using OneRecord.Api.SDK.Model;

namespace OneCheck.Application.Handlers.Queries;

public class GetCheckSheetRequestHandler : IRequestHandler<GetSheetRequest, SheetDto>
{
    public async Task<SheetDto> Handle(GetSheetRequest request, CancellationToken cancellationToken)
    {
        return new SheetDto();
    }

    private OriginPreparationSheetDto ConvertFromCheckToOriginPreparationSheetDto(Check check)
    {
        return new OriginPreparationSheetDto
        {
            Name = check.UsedTemplate.Questions.FirstOrDefault(x => x.HttpsCargoanswerOptionsText.Equals("Name")).HttpsCargoanswer.Text,
            SealNumber = check.UsedTemplate.Questions.FirstOrDefault(x => x.HttpsCargoanswerOptionsText.Equals("SealNumber")).HttpsCargoanswer.Text,
            Signature = check.UsedTemplate.Questions.FirstOrDefault(x => x.HttpsCargoanswerOptionsText.Equals("Signature")).HttpsCargoanswer.Text,
            AcceptedTempRange = check.UsedTemplate.Questions.FirstOrDefault(x => x.HttpsCargoanswerOptionsText.Equals("AcceptedTempRange")).HttpsCargoanswer.Text,
            EmergencyPhone = check.UsedTemplate.Questions.FirstOrDefault(x => x.HttpsCargoanswerOptionsText.Equals("EmergencyPhone")).HttpsCargoanswer.Text,
            IsBatteryCharged = Boolean.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.HttpsCargoanswerOptionsText.Equals("IsBatteryCharged")).HttpsCargoanswer.Text),
            IsContainerDamaged = Boolean.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.HttpsCargoanswerOptionsText.Equals("IsContainerDamaged")).HttpsCargoanswer.Text),
            ULDNumber = check.UsedTemplate.Questions.FirstOrDefault(x => x.HttpsCargoanswerOptionsText.Equals("ULDNumber")).HttpsCargoanswer.Text,
            Routing = check.UsedTemplate.Questions.FirstOrDefault(x => x.HttpsCargoanswerOptionsText.Equals("Routing")).HttpsCargoanswer.Text.Split(",").ToList(),
            Time = TimeOnly.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.HttpsCargoanswerOptionsText.Equals("Time")).HttpsCargoanswer.Text),
            Date = DateOnly.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.HttpsCargoanswerOptionsText.Equals("Date")).HttpsCargoanswer.Text),
            CheckSheetId = Guid.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.HttpsCargoanswerOptionsText.Equals("CheckSheetId")).HttpsCargoanswer.Text),
            ULDPrecooledTemp = int.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.HttpsCargoanswerOptionsText.Equals("ULDNumber")).HttpsCargoanswer.Text),
            BatteryStatusInPercent = int.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.HttpsCargoanswerOptionsText.Equals("BatteryStatusInPercent")).HttpsCargoanswer.Text),
            GoodsPrecooledAtTemps = int.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.HttpsCargoanswerOptionsText.Equals("GoodsPrecooledAtTemps")).HttpsCargoanswer.Text),
            TempSetting = int.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.HttpsCargoanswerOptionsText.Equals("TempSetting")).HttpsCargoanswer.Text),
            AWBNumber = int.Parse(check.UsedTemplate.Questions.FirstOrDefault(x => x.HttpsCargoanswerOptionsText.Equals("AWBNumber")).HttpsCargoanswer.Text),

        };
    }
}