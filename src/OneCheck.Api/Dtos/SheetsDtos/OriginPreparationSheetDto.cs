namespace OneCheck.Api.Dtos.SheetsDtos;
public class OriginPreparationSheetDto : CheckSheetDto
{
    public string ULDNumber { get; set; }
    public int AWBNumber { get; set; }
    public bool IsBatteryCharged { get; set; }
    public bool IsContainerDamaged { get; set; }
    public List<string> Routing { get; set; }
    public int GoodsPrecooledAtTemps { get; set; }
    public int ULDPrecooledTemp { get; set; }
    public int TempSetting { get; set; }
    public int AcceptedTempRange { get; set; }
    public string EmergencyPhone {  get; set; }
}
