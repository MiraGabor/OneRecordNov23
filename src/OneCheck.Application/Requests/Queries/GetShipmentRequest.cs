using MediatR;
using OneCheck.Application.Dtos;

namespace OneCheck.Application.Requests.Queries;

public class GetShipmentRequest : IRequest<ShipmentDto>
{
    public GetShipmentRequest(string httpsId)
    {
        throw new NotImplementedException();
    }
}