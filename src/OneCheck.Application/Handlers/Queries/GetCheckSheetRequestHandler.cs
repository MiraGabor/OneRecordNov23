using MediatR;
using OneCheck.Application.Dtos;
using OneCheck.Application.Dtos.SheetsDtos;
using OneCheck.Application.Requests.Queries;

namespace OneCheck.Application.Handlers.Queries;

public class GetCheckSheetRequestHandler : IRequestHandler<GetSheetRequest, SheetDto>
{
    public async Task<SheetDto> Handle(GetSheetRequest request, CancellationToken cancellationToken)
    {
        return new SheetDto();
    }
}