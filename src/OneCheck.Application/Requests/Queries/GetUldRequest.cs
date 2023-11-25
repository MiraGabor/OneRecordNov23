using MediatR;
using OneCheck.Application.Dtos;

namespace OneCheck.Application.Requests.Queries;

public class GetUldRequest : IRequest<UldDto>
{
}