using MediatR;
using OneCheck.Application.Dtos;
using OneCheck.Application.Requests.Queries;
using OneCheck.Domain.Contracts;

namespace OneCheck.Application.Handlers.Queries
{
    public class GetShipmentRequestHandler : IRequestHandler<GetShipmentRequest, ShipmentDto>
    {
        private readonly IShipmentRepository _shipmentRepository;

        public GetShipmentRequestHandler(IShipmentRepository shipmentRepository)
        {
            _shipmentRepository = shipmentRepository;
        }

        public async Task<ShipmentDto> Handle(GetShipmentRequest request, CancellationToken cancellationToken)
        {



            return new ShipmentDto
            {
                UldIdList = new List<string>
                {
                    "test 1",
                    "test 2"
                }
            };
        }
    }
}
