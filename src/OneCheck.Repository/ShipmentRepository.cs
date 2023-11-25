using OneCheck.Domain.Contracts;
using OneCheck.Domain.Model;

namespace OneCheck.Repository
{
    public class ShipmentRepository : IShipmentRepository
    {
        public async Task<ShipmentModel> Get(string id, CancellationToken cancellationToken)
        {
            return new ShipmentModel
            {
                Id = id,
                NeoneId = "neone test id 1",
            };
        }
    }
}
