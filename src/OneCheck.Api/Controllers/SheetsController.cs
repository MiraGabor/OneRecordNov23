using MediatR;
using Microsoft.AspNetCore.Mvc;
using OneCheck.Api.Dtos.SheetsDtos;
using OneCheck.Application.Requests.Queries;

namespace OneCheck.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class SheetsController : ControllerBase
{
    private readonly IMediator _mediator;

    public SheetsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{ULDId}")]
    public async Task<ActionResult<SheetDto>> GetSheetByUldId(string ULDId, CancellationToken cancellationToken = default)
    {
        var sheet = await _mediator.Send(new GetSheetRequest(ULDId));
        return Ok(sheet);
    }
}
