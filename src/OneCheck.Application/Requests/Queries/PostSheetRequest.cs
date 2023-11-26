using MediatR;
using OneCheck.Application.Dtos.SheetsDtos;

namespace OneCheck.Application.Requests.Queries;
public class PostSheetRequest : IRequest<Unit>
{
    public SheetDto Sheet { get; set; }

    public PostSheetRequest(SheetDto sheet) 
    { 
        Sheet = sheet;
    }
}