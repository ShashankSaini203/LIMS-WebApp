using LIMS.Domain.Models.Base;

namespace LIMS.Domain.Models
{
    public class CalibrationRecord : BaseModel
    {
        public Technician Technician { get; set; }
        public DateTime CalibrationDate { get; set; }
        public DateTime CalibrationDueDate { get; set; }
        public string Result { get; set; }
        public string Notes { get; set; }
    }
}
