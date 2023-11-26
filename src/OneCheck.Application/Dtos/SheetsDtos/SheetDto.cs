namespace OneCheck.Application.Dtos.SheetsDtos;
public class SheetDto
{
    public SheetDto() 
    {
        this.PreparationSheet =  new OriginPreparationSheetDto();
        this.TransitSheets  = new List<TransitSheetDto>();
        this.OriginHandlingAgentSheet = new OriginHandlingAgentSheetDto();
        this.DestinationHandlingAgentSheet = new DestinationHandlingAgentSheetDto();
        this.DestinationConsigneeSheet = new DestinationConsigneeSheetDto();
    }
    public Guid CheckSheetId { get; set; }

    public OriginPreparationSheetDto PreparationSheet { get; set;}
    public OriginHandlingAgentSheetDto OriginHandlingAgentSheet { get; set;}

    public IEnumerable<TransitSheetDto> TransitSheets { get; set;}
    public DestinationHandlingAgentSheetDto DestinationHandlingAgentSheet { get; set;}
    public DestinationConsigneeSheetDto DestinationConsigneeSheet { get; set;}
}
