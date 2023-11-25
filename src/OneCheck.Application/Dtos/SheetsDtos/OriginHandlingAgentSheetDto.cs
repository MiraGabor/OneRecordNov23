using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCheck.Application.Dtos.SheetsDtos;
public class OriginHandlingAgentSheetDto : CheckSheetDto
{
    public bool IsContainerDamaged { get; set; }
    public bool IsContainerOperating { get; set; }
    public int DisplayedTemp { get; set; }
    public bool IsAlert { get; set; }
    public BlueLightEnumDto BlueLight { get; set; }
    public string AlertDisplayed {  get; set; }
    public int SetTempOnDisplay {  get; set; }
    public bool Is5AdaptersPresents {  get; set; }
}
