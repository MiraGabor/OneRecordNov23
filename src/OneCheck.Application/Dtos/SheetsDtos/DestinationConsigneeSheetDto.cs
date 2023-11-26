namespace OneCheck.Application.Dtos.SheetsDtos;
public class DestinationConsigneeSheetDto : CheckSheetDto
{
    public bool IsContainerDamaged { get; set; }
    public bool IsContainerOperating { get; set; }
    public int DisplayedTemp { get; set; }
    public bool Is5AdaptersPresents { get; set; }
    public string RecipientName { get; set; }
    public string RecipientSignature { get; set; }
}
