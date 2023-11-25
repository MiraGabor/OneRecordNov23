using MediatR;
using OneCheck.Application.Dtos;
using OneCheck.Application.Dtos.SheetsDtos;

namespace OneCheck.Application.Requests.Queries
{
    public class CheckSheetRequest : IRequest<SheetDto>
    {
    }
}
