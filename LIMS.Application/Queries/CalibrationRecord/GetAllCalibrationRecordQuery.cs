using LIMS.Application.Responses;
using MediatR;

namespace LIMS.Application.Queries.CalibrationRecord
{
    public class GetAllCalibrationRecordQuery : IRequest<IEnumerable<CalibrationRecordResponse>>
    {
    }
}
