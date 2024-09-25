using System.ComponentModel.DataAnnotations;

namespace LIMS.Domain.Models
{
    public class CalibrationRecord
    {
        [Key]
        public int CalibrationRecordId { get; set; }
        public DateTime CurrentCalibrationDate { get; set; }
        public DateTime NextCalibrationDueDate { get; set; }
        public string Result { get; set; }
        public string Notes { get; set; }
        public int InstrumentId { get; set; }
        public int TechnicianId { get; set; }
    }
}
