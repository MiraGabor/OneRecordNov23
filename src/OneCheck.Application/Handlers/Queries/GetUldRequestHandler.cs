using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using OneCheck.Application.Dtos;
using OneCheck.Application.Requests.Queries;

namespace OneCheck.Application.Handlers.Queries
{
    public class GetUldRequestHandler : IRequestHandler<GetUldRequest, UldDto>
    {
        public Task<UldDto> Handle(GetUldRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
