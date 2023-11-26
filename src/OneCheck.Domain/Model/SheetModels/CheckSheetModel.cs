namespace OneCheck.Domain.Model.SheetModels;
public class CheckSheetModel
{
    public DateOnly Date { get; set; }
    public TimeOnly Time { get; set; }
    public string SealNumber { get; set; }
    public string Signature { get; set; }
    public string Name { get; set; }
    public int BatteryStatusInPercent { get; set; }

}
