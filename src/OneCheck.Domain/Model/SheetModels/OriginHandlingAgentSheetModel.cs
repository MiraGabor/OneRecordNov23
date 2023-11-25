using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCheck.Domain.Model.SheetModels;
public class OriginHandlingAgentSheetModel : CheckSheetModel
{
    public bool IsContainerDamaged { get; set; }
    public bool IsContainerOperating { get; set; }
    public int DisplayTemp { get; set; }
    public bool IsAlert { get; set; }
    public BlueLightEnumModel IsBlueLightOn { get; set; }
    public string AlertDisplayed {  get; set; }
    public int SetTempOnDisplay {  get; set; }
    public bool Is5AdaptersPresents {  get; set; }
}
