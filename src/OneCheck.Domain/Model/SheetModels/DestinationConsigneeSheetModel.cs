namespace OneCheck.Domain.Model.SheetModels;
public class DestinationConsigneeSheetModel : CheckSheetModel
{
    public bool IsContainerDamaged { get; set; }
    public bool IsContainerOperating { get; set; }
    public int DisplayTemp { get; set; }
    public bool Is5AdaptersPresents { get; set; }
    public string RecipientName { get; set; }
    public string RecipientSignature { get; set; }
}
