namespace OneCheck.Domain.Model.SheetModels;
public class OriginPreparationSheetModel : CheckSheetModel
{
    public string ULDNumber { get; set; }
    public int AWBNumber { get; set; }
    public bool IsBatteryCharged { get; set; }
    public bool IsContainerDamaged { get; set; }
    public List<string> Routing { get; set; }
    public int GoodsPrecooledAtTemps { get; set; }
    public int ULDPrecooledTemp { get; set; }
    public int TempSetting { get; set; }
    public string AcceptedTempRange { get; set; }
    public string EmergencyPhone {  get; set; }
}
