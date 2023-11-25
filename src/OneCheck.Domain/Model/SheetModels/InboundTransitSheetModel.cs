using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCheck.Domain.Model.SheetModels;
public class InboundTransitSheetModel
{
    public string InboundCheckAirportCode { get; set; }
    public BlueLightEnumModel BlueLight { get; set; }
    public bool IsAlarmDisplayed { get; set; }
}
