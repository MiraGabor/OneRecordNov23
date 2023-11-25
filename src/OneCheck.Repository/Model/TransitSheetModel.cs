﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCheck.Repository.Model;
public class TransitSheetModel : CheckSheetModel
{
    public string InboundCheckAirport { get; set; }
    public bool IsContainerOperating { get; set; }
    public bool IsContainerDamaged { get; set;}
    public int DisplayedTemp {  get; set; }
    public BlueLightEnum BlueLight { get; set;}
    public bool IsAlarmDisplayed { get; set; }

}
