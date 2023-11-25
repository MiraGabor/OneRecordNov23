using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCheck.Domain.Contracts;
public interface ICorrespondenceTableRepository
{
    public string GetShipmentIdFromULDId(string ULDId);
    public string GetULDIdFromShipmentId(string shipmentId);

    public void AddShipmentIDAndULDId(string ULDId, string shipmentId);
}
