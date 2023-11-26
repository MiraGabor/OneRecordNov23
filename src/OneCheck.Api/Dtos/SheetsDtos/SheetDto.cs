namespace OneCheck.Api.Dtos.SheetsDtos;
public class SheetDto
{
    public Guid CheckSheetId { get; set; }

    public OriginPreparationSheetDto PreparationSheet { get; set;}
    public OriginHandlingAgentSheetDto OriginHandlingAgentSheet { get; set;}

    public IEnumerable<TransitCheckSheetDto> InboundTransitSheets { get; set;}
    public DestinationHandlingAgentSheetDto DestinationHandlingAgentSheet { get; set;}
    public DestinationConsigneeSheetDto DestinationConsigneeSheet { get; set;}
}
