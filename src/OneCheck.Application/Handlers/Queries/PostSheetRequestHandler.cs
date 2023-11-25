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
        var firstCheck = FillCheckWithOriginPreparationSheetModel(request.Sheet.PreparationSheet);

        return null;
    }

    private Check FillCheckWithOriginPreparationSheetModel(OriginPreparationSheetDto originPreparationSheetDto)
    {

        var check = new Check();
        //check.Id = new Guid().ToString();
        check.ContactPersons = new List<Person> { new Person { HttpsCargolastName = originPreparationSheetDto.Name } };

        check.Type.Add("cargo:Check");
        check.UsedTemplate.Name = "OriginPreparationSheetDto";
        check.UsedTemplate.Questions.AddRange(new List<Question>
        {
            new Question
            {
                Type = new List<string> {"cargo:Question"},
                HttpsCargoshortText = "Name",
                HttpsCargoanswer = new Answer
                {
                    Text = originPreparationSheetDto.Name,
                }
            },
            new Question
            {
                HttpsCargoshortText = "Signature",
                HttpsCargoanswer = new Answer
                {
                    Text = originPreparationSheetDto.Signature,
                }
            },
            new Question
            {
                HttpsCargoshortText = "TempSetting",
                HttpsCargoanswer = new Answer
                {
                    Text = originPreparationSheetDto.TempSetting.ToString(),
                }
            },
            new Question
            {
                HttpsCargoshortText = "Time",
                HttpsCargoanswer = new Answer
                {
                    Text = originPreparationSheetDto.Time.ToString(),
                }
            },
            new Question
            {
                HttpsCargoshortText = "Date",
                HttpsCargoanswer = new Answer
                {
                    Text = originPreparationSheetDto.Date.ToString(),
                }
            },
            new Question
            {
                HttpsCargoshortText = "IsBatteryCharged",
                HttpsCargoanswer = new Answer
                {
                    Text = originPreparationSheetDto.IsBatteryCharged.ToString(),
                }
            },
             new Question
            {
                HttpsCargoshortText = "Routing",
                HttpsCargoanswer = new Answer
                {
                    Text = originPreparationSheetDto.Routing.ToString(),
                }
            }, new Question
            {
                HttpsCargoshortText = "IsContainerDamaged",
                HttpsCargoanswer = new Answer
                {
                    Text = originPreparationSheetDto.IsContainerDamaged.ToString(),
                }
            }, new Question
            {
                HttpsCargoshortText = "SealNumber",
                HttpsCargoanswer = new Answer
                {
                    Text = originPreparationSheetDto.SealNumber.ToString(),
                }
            }, new Question
            {
                HttpsCargoshortText = "ULDNumber",
                HttpsCargoanswer = new Answer
                {
                    Text = originPreparationSheetDto.ULDNumber.ToString(),
                }
            }, new Question
            {
                HttpsCargoshortText = "ULDPrecooledTemp",
                HttpsCargoanswer = new Answer
                {
                    Text = originPreparationSheetDto.ULDPrecooledTemp.ToString(),
                }
            }, new Question
            {
                HttpsCargoshortText = "GoodsPrecooledAtTemps",
                HttpsCargoanswer = new Answer
                {
                    Text = originPreparationSheetDto.GoodsPrecooledAtTemps.ToString(),
                }
            }, new Question
            {
                HttpsCargoshortText = "AcceptedTempRange",
                HttpsCargoanswer = new Answer
                {
                    Text = originPreparationSheetDto.AcceptedTempRange,
                }
            }, new Question
            {
                HttpsCargoshortText = "AWBNumber",
                HttpsCargoanswer = new Answer
                {
                    Text = originPreparationSheetDto.AWBNumber.ToString(),
                }
            }, new Question
            {
                HttpsCargoshortText = "CheckSheetId",
                HttpsCargoanswer = new Answer
                {
                    Text = originPreparationSheetDto.CheckSheetId.ToString(),
                }
            }, new Question
            {
                HttpsCargoshortText = "EmergencyPhone",
                HttpsCargoanswer = new Answer
                {
                    Text = originPreparationSheetDto.EmergencyPhone.ToString(),
                }
            }
        });
        return check;
    }
}
