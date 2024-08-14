using LIMS.Application.Responses;
using MediatR;

namespace LIMS.Application.Commands.Laboratory.Query
{
    public class GetAllLaboratoryQuery : IRequest<LaboratoryResponse>
    {
    }
}
