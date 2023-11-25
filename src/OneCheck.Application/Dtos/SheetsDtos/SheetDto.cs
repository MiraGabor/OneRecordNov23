using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OneCheck.Application.Dtos.SheetsDtos;
public class SheetDto
{
    public SheetDto() 
    {
        this.PreparationSheet =  new OriginPreparationSheetDto();
        this.InboundTransitSheets  = new List<InboundTransitSheetDto>();
        this.OriginHandlingAgentSheet = new OriginHandlingAgentSheetDto();
        this.DestinationHandlingAgentSheet = new DestinationHandlingAgentSheetDto();
        this.DestinationConsigneeSheet = new DestinationConsigneeSheetDto();
    }
    public Guid CheckSheetId { get; set; }

    public OriginPreparationSheetDto PreparationSheet { get; set;}
    public OriginHandlingAgentSheetDto OriginHandlingAgentSheet { get; set;}

    public IEnumerable<TransitCheckSheetDto> InboundTransitSheets { get; set;}
    public DestinationHandlingAgentSheetDto DestinationHandlingAgentSheet { get; set;}
    public DestinationConsigneeSheetDto DestinationConsigneeSheet { get; set;}
}
