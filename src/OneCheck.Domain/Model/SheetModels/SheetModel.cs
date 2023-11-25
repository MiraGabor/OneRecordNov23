using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCheck.Domain.Model.SheetModels;
public class SheetModel
{
    public Guid CheckSheetId { get; set; }

    public OriginPreparationSheetModel PreparationSheet { get; set;}
    public OriginHandlingAgentSheetModel OriginHandlingAgentSheet { get; set;}

    public IEnumerable<TransitSheetModel> InboundTransitSheets { get; set;}
    public DestinationHandlingAgentSheetModel DestinationHandlingAgentSheet { get; set;}
    public DestinationConsigneeSheetModel DestinationConsigneeSheet { get; set;}
}
