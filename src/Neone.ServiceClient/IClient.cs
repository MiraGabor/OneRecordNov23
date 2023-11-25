using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneRecord.Api.SDK.Model;

namespace Neone.ServiceClient
{
    public interface IClient
    {
        Task<Shipment?> GetShipment(string id);
        Task<LoadingUnit?> GetLoadingUnit(string id);
    }
}
