using MediatR;
using OneCheck.Application.Dtos.SheetsDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCheck.Application.Requests.Queries;
public class GetSheetRequest : IRequest<SheetDto>
{
    public string Id { get; set; }
    public GetSheetRequest(string id)
    {
        Id = id;
    }
}
