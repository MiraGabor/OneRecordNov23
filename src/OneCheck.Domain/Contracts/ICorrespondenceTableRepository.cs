namespace OneCheck.Domain.Contracts;
public interface ICorrespondenceTableRepository
{
    public string GetShipmentIdFromULDId(string ULDId);
    public List<string> GetULDIdsFromShipmentId(string shipmentId);

    public Task AddShipmentIDAndULDId(string ULDId, string shipmentId);

    public Task<string> GetHardcodedShipmentGuid(string shipmentId);
}
