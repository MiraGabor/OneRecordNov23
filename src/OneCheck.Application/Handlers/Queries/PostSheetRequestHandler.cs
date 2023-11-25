using MediatR;
using OneCheck.Application.Requests.Queries;
using OneRecord.Api.SDK.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCheck.Application.Handlers.Queries;
public class PostSheetRequestHandler : IRequestHandler<PostSheetRequest>
{
    public Task<Unit> Handle(PostSheetRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
