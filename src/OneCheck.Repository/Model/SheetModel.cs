namespace OneCheck.Repository.Model;
public class SheetModel
{
    public SheetModel()
    {
        this.PreparationSheet = new OriginPreparationSheetModel();
        this.InboundTransitSheets = new List<TransitSheetModel>();
        this.OriginHandlingAgentSheet = new OriginHandlingAgentSheetModel();
        this.DestinationHandlingAgentSheet = new DestinationHandlingAgentSheetModel();
        this.DestinationConsigneeSheet = new DestinationConsigneeSheetModel();
    }
    public Guid CheckSheetId { get; set; }

    public OriginPreparationSheetModel PreparationSheet { get; set; }
    public OriginHandlingAgentSheetModel OriginHandlingAgentSheet { get; set; }

    public IEnumerable<TransitSheetModel> InboundTransitSheets { get; set; }
    public DestinationHandlingAgentSheetModel DestinationHandlingAgentSheet { get; set; }
    public DestinationConsigneeSheetModel DestinationConsigneeSheet { get; set; }

}
