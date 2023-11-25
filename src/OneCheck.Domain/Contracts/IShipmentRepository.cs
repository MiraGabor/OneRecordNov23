using OneCheck.Domain.Model;

namespace OneCheck.Domain.Contracts;

public interface IShipmentRepository
{
    Task<ShipmentModel> Get(string id, CancellationToken cancellationToken);
}