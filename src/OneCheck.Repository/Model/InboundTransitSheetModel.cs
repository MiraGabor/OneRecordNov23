using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCheck.Repository.Model;
public class InboundTransitSheetModel
{
    public string InboundCheckAirportCode { get; set; }
    public BlueLightEnum BlueLight { get; set; }
    public bool IsAlarmDisplayed { get; set; }
}
