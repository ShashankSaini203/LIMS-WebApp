

namespace LIMS.Application.Queries.Laboratory
{
    public class GetLaboratoryByIdQuery : IRequest<LaboratoryResponse>
    {
        public int Id { get; set; }

        public GetLaboratoryByIdQuery(int id)
        {
            Id = id;
        }
    }
}
