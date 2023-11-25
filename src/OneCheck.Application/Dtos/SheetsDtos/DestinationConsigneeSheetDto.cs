﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCheck.Application.Dtos.SheetsDtos;
public class DestinationConsigneeSheetDto : CheckSheetDto
{
    public bool IsContainerDamaged { get; set; }
    public bool IsContainerOperating { get; set; }
    public int DisplayTemp { get; set; }
    public bool Is5AdaptersPresents { get; set; }
    public string RecipientName { get; set; }
    public string RecipientSignature { get; set; }
}
