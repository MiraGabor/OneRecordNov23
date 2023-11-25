﻿using System.Net.Http.Headers;
using Neone.ServiceClient;
using OneRecord.Api.SDK.Api;
using OneRecord.Api.SDK.Client;
using OneRecord.Api.SDK.Model;

var piece = new Piece()
{
    Type = new List<string>{ "cargo:Piece" },
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
    UldReference = new LoadingUnit
    {
        Type = new List<string>
        {
            "cargo:LoadingUnit"
        },
        
    },
    
};

var token =
    "eyJhbGciOiJSUzI1NiIsInR5cCIgOiAiSldUIiwia2lkIiA6ICJGYzdaSHZUNGozbldNenZkX2xuYUsySGZWWnUtYWtBLTB0TGMwLVgwc1BZIn0.eyJleHAiOjE3MDA4OTk5MDUsImlhdCI6MTcwMDg5OTYwNSwianRpIjoiNzdhNWExYjQtYWFiNC00M2FhLTg2NDctNzI3MGJmMzAzMTFkIiwiaXNzIjoiaHR0cDovL2xvY2FsaG9zdDo4MDg5L3JlYWxtcy9uZW9uZSIsImF1ZCI6ImFjY291bnQiLCJzdWIiOiIwYWU4OThmMy1kMjQ4LTRlYWMtODY4MS1iMDM4MWM4MmQ2YzAiLCJ0eXAiOiJCZWFyZXIiLCJhenAiOiJuZW9uZS1jbGllbnQiLCJhY3IiOiIxIiwiYWxsb3dlZC1vcmlnaW5zIjpbIioiXSwicmVhbG1fYWNjZXNzIjp7InJvbGVzIjpbIm9mZmxpbmVfYWNjZXNzIiwiZGVmYXVsdC1yb2xlcy1uZW9uZSIsInVtYV9hdXRob3JpemF0aW9uIl19LCJyZXNvdXJjZV9hY2Nlc3MiOnsiYWNjb3VudCI6eyJyb2xlcyI6WyJtYW5hZ2UtYWNjb3VudCIsIm1hbmFnZS1hY2NvdW50LWxpbmtzIiwidmlldy1wcm9maWxlIl19fSwic2NvcGUiOiJwcm9maWxlIGVtYWlsIiwiY2xpZW50SG9zdCI6IjE3Mi4yMS4wLjEiLCJlbWFpbF92ZXJpZmllZCI6ZmFsc2UsImxvZ2lzdGljc19hZ2VudF91cmkiOiJodHRwOi8vbG9jYWxob3N0OjgwODAvbG9naXN0aWNzLW9iamVjdHMvX2RhdGEtaG9sZGVyIiwicHJlZmVycmVkX3VzZXJuYW1lIjoic2VydmljZS1hY2NvdW50LW5lb25lLWNsaWVudCIsImNsaWVudEFkZHJlc3MiOiIxNzIuMjEuMC4xIiwiY2xpZW50X2lkIjoibmVvbmUtY2xpZW50In0.bcJ87u1EVFv1pfxX0VK7nWfrLAfqpkREA4Utse3_CGmHukQ70l3vqqrqo10wWBdIkgll7JXIjsjcYt38w3f7dgRBVjsHzCwf65CiGjI7-eoYx_sWB0nFE4_Q-XOZky8HhWM6M02CIPI1O-ubFRO7Z3rvLo_PvneboVLmrHWEFWOVv_3g7no78cdsXzY-5yqJtdk483Y2hV1Ure_VvyAOeCASZYexFVlkFoMWBsyFku8cnuyQxxB-8OcxPBOX3KczefzUxHe7_xn8Ez50Hc4-emseoQf__Ync_DY3hFvHGh1aEul0cVWeGlEXuXEVY7J8OItjdy3L1bS14flInqvUUg";

//Configuration config = new Configuration
//{
//    HttpsBasePath = "http://localhost:8080",
//    HttpsDefaultHeaders = new Dictionary<string, string>
//    {
//        { "Authentication", $"Bearer {token}" }
//    },
//};

//var apiClient = new LogisticsObjectsApi(config);

//var result = await apiClient.CreateLogisticsObjectWithHttpInfoAsync(piece);

//result.HttpsHeaders.TryGetValue("Location", out var location);


//var pieceId = GetIdFromResponse(result);

//Console.WriteLine(pieceId);


//var shipment = new Shipment
//{
//    Type = new List<string>
//    {
//        "cargo:Shipment"
//    },
//    GoodsDescription = "a shipment with a single piece",
//    ShipmentOfPieces = new List<Piece>
//    {
//        piece
//        //new Piece
//        //{
//        //    //Id = location.FirstOrDefault(),
//        //    Type = new List<string>
//        //    {
//        //        "cargo:Piece"
//        //    }
//        //}
//    },
//    Waybill = new Waybill
//    {
//        Type = new List<string>
//        {
//            "cargo:WayBill"
//        },
//        WaybillNumber = "1234456789",
        
//    }

//};

//var shipmentCreateResponse = await apiClient.CreateLogisticsObjectWithHttpInfoAsync(shipment);
//var shipmentId = GetIdFromResponse(shipmentCreateResponse);

//Console.WriteLine(shipmentId);

var client = new Client(token);


var aaaa = await client.GetShipment("bf96675b-b56e-4f46-b3ff-dcdd8827bc76");
Console.WriteLine(aaaa.GoodsDescription);

string GetIdFromResponse(ApiResponse<object> httpsResult)
{
    var location = httpsResult.HttpsHeaders.TryGetValue("Location", out var value);

    var id = new Uri(value.First()).Segments.Last();

    return id;
}
