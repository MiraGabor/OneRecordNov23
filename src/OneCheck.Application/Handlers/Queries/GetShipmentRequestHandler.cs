using MediatR;
using Neone.ServiceClient;
using OneCheck.Application.Dtos;
using OneCheck.Application.Requests.Queries;
using OneCheck.Domain.Contracts;

namespace OneCheck.Application.Handlers.Queries
{
    public class GetShipmentRequestHandler : IRequestHandler<GetShipmentRequest, ShipmentDto>
    {
        private readonly IClient _client;
        private readonly ICorrespondenceTableRepository _repository;

        public GetShipmentRequestHandler(IClient client, ICorrespondenceTableRepository repository)
        {
            _client = client;
            _repository = repository;
        }

        public async Task<ShipmentDto> Handle(GetShipmentRequest request, CancellationToken cancellationToken)
        {
            var id = await _repository.GetHardcodedShipmentGuid(request.Id);

            var shipment = await _client.GetShipment(id, cancellationToken);

            return new ShipmentDto
            {
                UldDictionary = shipment.UldDictionary,
                ArrivalCode = shipment.ArrivalCode,
                DepartureCode = shipment.DepartureCode,
                TransitCodes = shipment.TransitCodes,
            };
        }
    }
}
