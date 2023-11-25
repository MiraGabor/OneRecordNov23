using MediatR;
using OneCheck.Application.Dtos;

namespace OneCheck.Application.Requests.Queries
{
    public class CheckSheetRequest : IRequest<CheckSheetDto>
    {
    }
}
