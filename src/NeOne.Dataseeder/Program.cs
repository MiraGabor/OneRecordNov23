using OneRecord.Api.SDK.Api;
using OneRecord.Api.SDK.Client;
using OneRecord.Api.SDK.Model;

var token = await TokenClient.GetAccessToken(@"http://localhost:8089", "neone", "neone-client",
    "lx7ThS5aYggdsMm42BP3wMrVqKm9WpNY");

Configuration config = new Configuration
{
    HttpsBasePath = "http://localhost:8080",
    HttpsDefaultHeaders = new Dictionary<string, string>
    {
        { "Authorization", $"Bearer {token}" },
        { "Authentication", $"Bearer {token}" }
    },
    HttpsAccessToken = Guid.NewGuid().ToString()
};

var apiClient = new LogisticsObjectsApi(config);

var uld = new ULD
{
    Type = new List<string>
    {
        "cargo:LoadingUnit"
    },
    UldSerialNumber = "RKN61424PC"
};

var piece = new Piece()
{
    Type = new List<string> { "cargo:Piece" },
    Coload = false,
    HandlingInstructions = new List<HandlingInstructions>
    {
        new HandlingInstructions
        {
            HttpsCargohandlingInstructionsType = "SPH",
            HttpsCargohandlingInstructionsTypeCode = "VAL",
            HttpsCargodescription = "Valuable Cargo",
            Type = new List<string>{ "cargo:HandlingInstructions"},

        }
    },
    UldReference = uld
    
};

var shipment = new Shipment
{
    Type = new List<string>
    {
        "cargo:Shipment"
    },
    GoodsDescription = "a shipment with a single piece",
    ShipmentOfPieces = new List<Piece>
    {
        piece
    },
    Waybill = new Waybill
    {
        Type = new List<string>
        {
            "cargo:WayBill"
        },
        WaybillNumber = "724-24112023",
    }

};

var shipmentCreateResponse = await apiClient.CreateLogisticsObjectWithHttpInfoAsync(shipment);
var shipmentId = GetIdFromResponse(shipmentCreateResponse);

Console.WriteLine(shipmentId);


//var client = new Client(token);

var s = apiClient.GetLogisticsObjectWithHttpInfo(shipmentId);

string jsonString = s?.HttpsData?.ToString() ?? String.Empty;

//var typed = JsonSerializer.Deserialize<Shipment>(jsonString);

Console.WriteLine(jsonString);





//var aaaa = await client.GetShipment("bf96675b-b56e-4f46-b3ff-dcdd8827bc76");
//Console.WriteLine(aaaa.GoodsDescription);

string GetIdFromResponse(ApiResponse<object> httpsResult)
{
    var location = httpsResult.HttpsHeaders.TryGetValue("Location", out var value);

    var id = new Uri(value.First()).Segments.Last();

    return id;
}
