namespace OneCheck.Application.Dtos.SheetsDtos;
public class OriginHandlingAgentSheetDto : CheckSheetDto
{
    public bool IsContainerDamaged { get; set; }
    public bool IsContainerOperating { get; set; }
    public int DisplayedTemp { get; set; }
    public bool IsAlert { get; set; }
    public BlueLightEnumDto IsBlueLightOn { get; set; }
    public string AlertDisplayed {  get; set; }
    public int SetTempOnDisplay {  get; set; }
    public bool Is5AdaptersPresents {  get; set; }
}
