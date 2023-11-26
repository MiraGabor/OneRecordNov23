using MediatR;
using OneCheck.Application.Dtos.SheetsDtos;

namespace OneCheck.Application.Requests.Queries;
public class GetSheetRequest : IRequest<SheetDto>
{
    public string Id { get; set; }
    public GetSheetRequest(string id)
    {
        Id = id;
    }
}
