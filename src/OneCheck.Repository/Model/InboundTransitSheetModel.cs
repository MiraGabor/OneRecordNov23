namespace OneCheck.Repository.Model;
public class InboundTransitSheetModel
{
    public string InboundCheckAirportCode { get; set; }
    public BlueLightEnum BlueLight { get; set; }
    public bool IsAlarmDisplayed { get; set; }
}
