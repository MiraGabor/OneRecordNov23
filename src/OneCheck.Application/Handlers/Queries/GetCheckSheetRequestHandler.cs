using MediatR;
using OneCheck.Application.Dtos;
using OneCheck.Application.Requests.Queries;

namespace OneCheck.Application.Handlers.Queries;

public class GetCheckSheetRequestHandler : IRequestHandler<CheckSheetRequest, CheckSheetDto>
{
    public Task<CheckSheetDto> Handle(CheckSheetRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}