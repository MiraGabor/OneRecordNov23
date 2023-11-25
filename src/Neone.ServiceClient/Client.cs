using OneRecord.Api.SDK.Api;
using OneRecord.Api.SDK.Client;
using OneRecord.Api.SDK.Model;

namespace Neone.ServiceClient
{
    public class Client : IClient
    {

        private readonly LogisticsObjectsApi _logisticsObjectsApi;

        public Client(string token)
        {
            //TODO get token


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
            return response.HttpsContent as Shipment;
        }

        public async Task<LoadingUnit?> GetLoadingUnit(string id)
        {
            var response = await _logisticsObjectsApi.GetLogisticsObjectWithHttpInfoAsync(id);
            return response.HttpsContent as LoadingUnit;
        }

        public async Task UpdateLoadingUnit(string id)
        {
            //_logisticsObjectsApi.UpdateLogisticsObjectWithHttpInfoAsync(id, cha)
        }
    }
}
