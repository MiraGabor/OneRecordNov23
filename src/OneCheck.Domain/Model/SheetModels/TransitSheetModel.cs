using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCheck.Domain.Model.SheetModels;
public class TransitSheetModel
{
    public InboundTransitSheetModel  InboundTransitSheetModel { get; set; }
    public OutboundTransitSheetModel OutboundTransitSheetModel { get; set;}
}
