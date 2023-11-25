using MediatR;
using OneCheck.Application.Dtos;

namespace OneCheck.Application.Requests.Queries;

public record GetShipmentRequest(string Id) : IRequest<ShipmentDto>
{
}