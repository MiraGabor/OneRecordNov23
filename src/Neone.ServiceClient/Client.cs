using OneRecord.Api.SDK.Model;

namespace Neone.ServiceClient
{
    public class Client : IClient
    {
        public async Task<Shipment> GetShipment(string id)
        {
            return new Shipment
            {

            };
        }
    }
}
