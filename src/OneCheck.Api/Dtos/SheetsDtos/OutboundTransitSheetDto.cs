﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCheck.Api.Dtos.SheetsDtos;
public class OutboundTransitSheetDto : TransitCheckSheetDto
{
    public string OutboundCheckAirportCode {  get; set; }
}