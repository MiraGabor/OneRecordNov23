using OneRecord.Api.SDK.Api;
using OneRecord.Api.SDK.Client;
using OneRecord.Api.SDK.Model;

namespace Neone.ServiceClient
{
    public class Client : IClient
    {

        private readonly LogisticsObjectsApi _logisticsObjectsApi;

        public Client()
        {
            var token = TokenClient.GetAccessToken(@"http://localhost:8089", "neone", "neone-client",
                "lx7ThS5aYggdsMm42BP3wMrVqKm9WpNY").GetAwaiter().GetResult();

            Configuration config = new Configuration
            {
                HttpsBasePath = "http://localhost:8080",
                HttpsDefaultHeaders = new Dictionary<string, string>
                {
                    { "Authentication", $"Bearer {token}" }
                },
            };

            _logisticsObjectsApi = new LogisticsObjectsApi(config);
        }

        public async Task<Shipment?> GetShipment(string id)
        {
            var response = await _logisticsObjectsApi.GetLogisticsObjectWithHttpInfoAsync(id);
            return (Shipment)response.HttpsData;
        }

        public async Task<LoadingUnit?> GetLoadingUnit(string id)
        {
            var response = await _logisticsObjectsApi.GetLogisticsObjectWithHttpInfoAsync(id);
            return (LoadingUnit)response.HttpsData;
        }

        public async Task<Piece> GetPiece(string id)
        {
            var response = await _logisticsObjectsApi.GetLogisticsObjectWithHttpInfoAsync(id);
            return (Piece) response.HttpsData;
        }

        public async Task<Waybill> GetWayBill(string id)
        {
            var response = await _logisticsObjectsApi.GetLogisticsObjectWithHttpInfoAsync(id);
            return (Waybill)response.HttpsData;
        }
    }
}
