using OneRecord.Api.SDK.Api;
using OneRecord.Api.SDK.Client;
using OneRecord.Api.SDK.Model;

var apiClient = await GetLogisticsObjectsApi();

//var checks = GetChecks();
var uld = GetUld();
//var piece = GetPiece(uld);
//var shipment = GetShipment(piece);
//var shipmentId = await CreateShipment(apiClient, shipment);

//Console.WriteLine(shipmentId);

var check = GetCheck();

var checkCreateResponse = await apiClient.CreateLogisticsObjectWithHttpInfoAsync(check);
checkCreateResponse.HttpsHeaders.TryGetValue("Location", out var checkLocation);

var checkCreateResponse2 = await apiClient.CreateLogisticsObjectWithHttpInfoAsync(check);
checkCreateResponse2.HttpsHeaders.TryGetValue("Location", out var checkLocation2);
//var checkId = GetIdFromResponse(checkCreateResponse);


var uldCreateResponse = await apiClient.CreateLogisticsObjectWithHttpInfoAsync(uld);
var uldId = GetIdFromResponse(uldCreateResponse);
//add remarks string

uldCreateResponse.HttpsHeaders.TryGetValue("Location", out var value);

var change = GetChangerRequest(value.First(), new List<string> { checkLocation.First(), checkLocation2.First() });
var updateResponse = apiClient.UpdateLogisticsObjectWithHttpInfo(uldId, change);



var s = apiClient.GetLogisticsObjectWithHttpInfo(uldId);
string jsonString = s?.HttpsData?.ToString() ?? String.Empty;
Console.WriteLine(jsonString);


async Task<LogisticsObjectsApi> GetLogisticsObjectsApi()
{
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

    var httpsApiClient = new LogisticsObjectsApi(config);
    return httpsApiClient;
}

List<Check> GetChecks()
{
    return new List<Check>
    {
        GetCheck()

    };
}

ULD GetUld()
{
    var httpsUld = new ULD
    {
        Type = new List<string>
        {
            "cargo:LoadingUnit",
            "cargo:LogisticsObject"
        },
        UldSerialNumber = "RKN61424PC",


    };
    return httpsUld;
}

Piece GetPiece(ULD httpsUld1)
{
    var httpsPiece = new Piece()
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
                Type = new List<string> { "cargo:HandlingInstructions" },
            }
        },
        UldReference = httpsUld1
    };
    return httpsPiece;
}

Shipment GetShipment(Piece httpsPiece1)
{
    var httpsShipment = new Shipment
    {
        Type = new List<string>
        {
            "cargo:Shipment"
        },
        GoodsDescription = "a shipment with a single piece",
        ShipmentOfPieces = new List<Piece>
        {
            httpsPiece1
        },

        Waybill = new Waybill
        {
            Type = new List<string>
            {
                "cargo:WayBill"
            },
            WaybillNumber = "724-24112023",
            ReferredBookingOption = new Booking
            {
                Type = new List<string>
                {
                    "cargo:Booking"
                },
                HttpsCargoforBookingRequest = new BookingRequest
                {
                    Type = new List<string>
                    {
                        "cargo:BookingRequest"
                    },
                    HttpsCargobookingOption = new BookingOption
                    {
                        Type = new List<string>
                        {
                            "cargo:BookingOption"
                        },
                        TransportLegs = new List<TransportLegs>
                        {
                            new()
                            {
                                Type = new List<string>
                                {
                                    "cargo:TransportLegs",
                                    "cargo:LogisticsObject"
                                },
                                TransportIdentifier = "LX177",
                                DepartureDate = new DateTime(2023, 11, 25, 00, 05, 00),
                                DepartureLocation = new Location
                                {
                                    Type = new List<string>
                                    {
                                        "cargo:Location"
                                    },
                                    HttpsCargocode = "SIN"
                                },
                                ArrivalLocation = new Location
                                {
                                    Type = new List<string>
                                    {
                                        "cargo:Location"
                                    },
                                    HttpsCargocode = "ZRH"
                                },
                                LegNumber = 1
                            },
                            new()
                            {
                                Type = new List<string>
                                {
                                    "cargo:TransportLegs",
                                    "cargo:LogisticsObject"
                                },
                                TransportIdentifier = "LX18",
                                DepartureDate = new DateTime(2023, 11, 26, 00, 05, 00),
                                DepartureLocation = new Location
                                {
                                    Type = new List<string> { "cargo:Location" },
                                    HttpsCargocode = "ZRH"
                                },
                                ArrivalLocation = new Location
                                {
                                    Type = new List<string> { "cargo:Location" },
                                    HttpsCargocode = "JFK"
                                },
                                LegNumber = 2
                            }
                        }
                    }
                }
            }
        },
    };
    return httpsShipment;
}

string GetIdFromResponse(ApiResponse<object> httpsResult)
{
    var location = httpsResult.HttpsHeaders.TryGetValue("Location", out var value);

    var id = new Uri(value.First()).Segments.Last();

    return id;
}

async Task<string> CreateShipment(LogisticsObjectsApi httpsLogisticsObjectsApi, Shipment httpsShipment1)
{
    var shipmentCreateResponse = await httpsLogisticsObjectsApi.CreateLogisticsObjectWithHttpInfoAsync(httpsShipment1);
    var httpsShipmentId = GetIdFromResponse(shipmentCreateResponse);
    return httpsShipmentId;
}

Check GetCheck()
{
    return new Check
    {
        Type = new List<string>
        {
            "cargo:Check",
            "cargo:LogisticsObject"
        },
        UsedTemplate = new CheckTemplate
        {
            Type = new List<string>
            {
                "cargo:CheckTemplate"
            },
            Name = "OriginPreparationSheetDto",
            Questions = new List<Question>
            {
                new Question
                {
                    Type = new List<string>
                    {
                        "cargo:Question"
                    },
                    ShortText = "Signature",
                    Answer = new Answer
                    {
                        Type = new List<string>
                        {
                            "cargo:Answer"
                        },
                        Text = "Blaaaaaaaa"
                    },
                },
                new Question
                {
                    Type = new List<string>
                    {
                        "cargo:Question"
                    },
                    ShortText = "Random stuff",
                    Answer = new Answer
                    {
                        Type = new List<string>
                        {
                            "cargo:Answer"
                        },
                        Text = "Something els"
                    },
                },
            }
        },

    };
}

Change GetChangerRequest(string listReference, IList<string> checkLocations)
{

    var operations = new List<Operation>();

    foreach (var checkLocation in checkLocations)
    {
        operations.Add(GetOperation(listReference, checkLocation));
    }

    var httpsChange = new Change
    {
        Type = "api:Change",
        HasLogisticsObject = new LogisticsObject
        {
            Id = listReference,
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


Operation GetOperation(string listReference, string checkReference)
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