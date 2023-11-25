using OneCheck.Domain.Contracts;
using OneCheck.Repository.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCheck.Repository;
public class CorrespondenceTableRepository : ICorrespondenceTableRepository
{
    private CorrespondenceTableContext _correspondenceTableContext;
    public CorrespondenceTableRepository(CorrespondenceTableContext context) 
    { 
        _correspondenceTableContext = context;
    }

    public void AddShipmentIDAndULDId(string ULDId, string shipmentId)
    {
        throw new NotImplementedException();
    }

    public string GetShipmentIdFromULDId(string ULDId)
    {
        throw new NotImplementedException();
    }

    public string GetULDIdFromShipmentId(string shipmentId)
    {
        throw new NotImplementedException();
    }
}
