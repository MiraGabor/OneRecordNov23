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

        public async Task<bool> UpdateCheckList(string uldId, List<Check> checks)
        {
            List<string> checkReferences = new List<string>();

            //create checks
            foreach (var check in checks)
            {
                var checkCreateResponse = await _logisticsObjectsApi.CreateLogisticsObjectWithHttpInfoAsync(check);
                checkCreateResponse.HttpsHeaders.TryGetValue("Location", out var checkReference);
                checkReferences.Add(checkReference.First());
            }

            var s = _logisticsObjectsApi.GetLogisticsObjectWithHttpInfo(uldId);

            var uld = (ULD)s.HttpsData;
            //string jsonString = s?.HttpsData?.ToString() ?? String.Empty;
            //get uld
            var uldReference = uld.Id;
            
            var changes = GetChangeRequestForUld(uldReference, checkReferences);

            var response = _logisticsObjectsApi.UpdateLogisticsObjectWithHttpInfoAsync(uldId, changes);
            return true;
        }

        private Change GetChangeRequestForUld(string uldReference, IList<string> checkReferences)
        {
            var operations = new List<Operation>();

            foreach (var checkLocation in checkReferences)
            {
                operations.Add(GetOperation(uldReference, checkLocation));
            }

            var httpsChange = new Change
            {
                Type = "api:Change",
                HasLogisticsObject = new LogisticsObject
                {
                    Id = uldReference,
                },
                HasDescription = "Add checks",
                HasOperation = operations,
                HasRevision = new Revision
                {
                    Type = "http://www.w3.org/2001/XMLSchema#positiveInteger",
                    Value = 1
                }
            };
            return httpsChange;
        }

        private Operation GetOperation(string listReference, string checkReference)
        {
            return new Operation
            {
                Type = "api:Operation",
                PatchOperation = new PatchOperation
                {
                    Id = "api:ADD"
                },
                Subject = listReference,
                Predicate = "https://onerecord.iata.org/ns/cargo#checks",
                Objects = new List<OperationObject>
                {
                    new OperationObject
                    {
                        Type = "api:OperationObject",
                        HasDatatype = "https://onerecord.iata.org/ns/cargo#Check",
                        HasValue = checkReference
                    }
                }
            };
        }

    }
}
