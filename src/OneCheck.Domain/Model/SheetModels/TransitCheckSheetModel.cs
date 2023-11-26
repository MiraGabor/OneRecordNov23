namespace OneCheck.Domain.Model.SheetModels;
public class TransitCheckSheetModel : CheckSheetModel
{
    public string InboundCheckAirport { get; set; }
    public bool IsContainerOperating { get; set; }
    public bool IsContainerDamaged { get; set;}
    public int DisplayedTemp {  get; set; }
    public BlueLightEnumModel BlueLight { get; set;}
    public bool IsAlarmDisplayed { get; set; }

}
