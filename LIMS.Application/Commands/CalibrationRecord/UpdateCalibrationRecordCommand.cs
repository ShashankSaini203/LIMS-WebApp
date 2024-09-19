using MediatR;
using LIMS.Application.Responses;
using System.ComponentModel.DataAnnotations;

namespace LIMS.Application.Commands.CalibrationRecord
{
    public class UpdateCalibrationRecordCommand : IRequest<CalibrationRecordResponse>
    {
        public string Id { get; set; }
        public DateTime CurrentCalibrationDate { get; set; }
        public DateTime NextCalibrationDueDate { get; set; }
        public string Result { get; set; }
        public string Notes { get; set; }
        public int TechnicianId { get; set; }
        public string TechnicianName { get; set; }
    }
}
