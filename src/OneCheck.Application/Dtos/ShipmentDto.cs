namespace OneCheck.Application.Dtos;

public class ShipmentDto
{
    public Dictionary<string,string> UldDictionary { get; set; }
    public string ArrivalCode { get; set; }
    public string DepartureCode { get; set; }
    public List<string> TransitCodes { get; set; }
}