namespace OneCheck.Api.Dtos.SheetsDtos;
public class TransitCheckSheetDto : CheckSheetDto
{
    public string InboundCheckAirport { get; set; }
    public bool IsContainerOperating { get; set; }
    public bool IsContainerDamaged { get; set;}
    public int DisplayedTemp {  get; set; }
    public BlueLightEnumDto BlueLight { get; set;}
    public bool IsAlarmDisplayed { get; set; }

}
