using LIMS.Application.Responses;
using MediatR;

namespace LIMS.Application.Queries.CalibrationRecord
{
    public class GetCalibrationRecordByIdQuery : IRequest<CalibrationRecordResponse>
    {
        public int Id { get; set; }

        public GetCalibrationRecordByIdQuery(int id)
        {
            Id = id;
        }
    }
}
