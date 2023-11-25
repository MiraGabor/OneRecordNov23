using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCheck.Api.Dtos.SheetsDtos;
public class InboundTransitSheetDto : TransitCheckSheetDto
{
    public string InboundCheckAirportCode { get; set; }
    public BlueLightEnumDto BlueLight { get; set; }
    public bool IsAlarmDisplayed { get; set; }
}
