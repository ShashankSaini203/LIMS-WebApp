using LIMS.Domain.Models.Base;

namespace LIMS.Domain.Models
{
    public class CalibrationRecord : BaseModel
    {
        public DateTime CurrentCalibrationDate { get; set; }
        public DateTime NextCalibrationDueDate { get; set; }
        public string Result { get; set; }
        public string Notes { get; set; }
        public int TechnicianId { get; set; }
        public string TechnicianName { get; set; }
    }
}
