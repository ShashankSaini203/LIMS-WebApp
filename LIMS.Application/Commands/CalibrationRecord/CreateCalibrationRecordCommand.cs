using MediatR;
using LIMS.Application.Responses;

namespace LIMS.Application.Commands.CalibrationRecord
{
    public class CreateCalibrationRecordCommand : IRequest<CalibrationRecordResponse>
    {     
        public DateTime CurrentCalibrationDate { get; set; }
        public DateTime NextCalibrationDueDate { get; set; }
        public string Result { get; set; }
        public string Notes { get; set; }
        public int TechnicianId { get; set; }
        public string TechnicianName { get; set; }

    }
}
