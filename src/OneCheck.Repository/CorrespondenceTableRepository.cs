using OneCheck.Domain.Contracts;
using OneCheck.Repository.DBContext;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneCheck.Repository.Model;

namespace OneCheck.Repository;
public class CorrespondenceTableRepository : ICorrespondenceTableRepository
{
    private CorrespondenceTableContext _correspondenceTableContext;
    public CorrespondenceTableRepository(CorrespondenceTableContext context) 
    { 
        _correspondenceTableContext = context;
    }

    public async Task AddShipmentIDAndULDId(string ULDId, string shipmentId)
    {
        using (var db = _correspondenceTableContext)
        {
            var correspondenceULDShipmentModel = new CorrespondenceULDShipmentModel();
            correspondenceULDShipmentModel.ShipmentId = shipmentId;
            correspondenceULDShipmentModel.UldID = ULDId;
            db.correspondenceULDShipmentModel.Add(correspondenceULDShipmentModel);
            await db.SaveChangesAsync();
        }
    }

    public string GetShipmentIdFromULDId(string ULDId)
    {
        using (var db = _correspondenceTableContext)
        { 
            var correspondenceULDShipmentModel = db.correspondenceULDShipmentModel.Where(x => x.UldID == ULDId).FirstOrDefault();
            if (correspondenceULDShipmentModel != null)
            {
                return correspondenceULDShipmentModel.ShipmentId;
            }
            return string.Empty;
        }
    }

    public List<string> GetULDIdsFromShipmentId(string shipmentId)
    {
        using (var db = _correspondenceTableContext)
        {
            var correspondenceULDShipmentModel = db.correspondenceULDShipmentModel.Where(x => x.ShipmentId == shipmentId).ToList();
            if (correspondenceULDShipmentModel != null)
            {
                return correspondenceULDShipmentModel.Select(x => x.UldID).ToList();
            }
            return new List<string>();
        }
    }
}
