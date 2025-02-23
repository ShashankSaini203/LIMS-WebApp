using LIMS.Application.Responses;
using MediatR;

namespace LIMS.Application.Queries.Laboratory
{
    public class GetLaboratoryByIdQuery : IRequest<LaboratoryResponse>
    {
        public int LaboratoryId { get; set; }

        public GetLaboratoryByIdQuery(int laboratoryId)
        {
            LaboratoryId = laboratoryId;
        }
    }
}
