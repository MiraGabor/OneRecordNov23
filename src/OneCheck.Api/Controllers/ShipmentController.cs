using MediatR;

using Microsoft.AspNetCore.Mvc;
using OneCheck.Application.Dtos;
using OneCheck.Application.Requests.Queries;

namespace OneCheck.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipmentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ShipmentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ShipmentDto>> GetShipment(string id, CancellationToken cancellationToken = default)
        {
            var shipment = await _mediator.Send(new GetShipmentRequest(id), cancellationToken);
            return Ok(shipment);
        }
    }
}
