using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCheck.Repository.Model;
public class CheckSheetModel
{
    public DateOnly Date { get; set; }
    public TimeOnly Time { get; set; }
    public string SealNumber { get; set; }
    public string Signature { get; set; }
    public string Name { get; set; }
    public int BatteryStatusInPercent { get; set; }

}
