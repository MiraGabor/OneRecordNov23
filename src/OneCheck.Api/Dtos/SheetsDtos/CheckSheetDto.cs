namespace OneCheck.Api.Dtos.SheetsDtos;
public class CheckSheetDto
{
    public Guid CheckSheetId { get; set; }
    public DateOnly Date { get; set; }
    public TimeOnly Time { get; set; }
    public string SealNumber { get; set; }
    public string Signature { get; set; }
    public string Name { get; set; }
    public int BatteryStatusInPercent { get; set; }

}
