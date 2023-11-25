using MediatR;
using OneCheck.Application.Dtos.SheetsDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCheck.Application.Requests.Queries;
public class PostSheetRequest : IRequest<Unit>
{
    public SheetDto Sheet { get; set; }

    public PostSheetRequest(SheetDto sheet) 
    { 
        Sheet = sheet;
    }
}