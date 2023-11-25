using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCheck.Domain.Contracts;
public interface ICorrespondenceTableRepository
{
    public string GetShipmentIdFromULDId(string ULDId);
    public List<string> GetULDIdsFromShipmentId(string shipmentId);

    public Task AddShipmentIDAndULDId(string ULDId, string shipmentId);
}
