namespace LIMS.Application.Responses
{
    public class CalibrationRecordResponse
    {
        public int CalibrationRecordId { get; set; }
        public DateTime CurrentCalibrationDate { get; set; }
        public DateTime NextCalibrationDueDate { get; set; }
        public string Result { get; set; }
        public string Notes { get; set; }
        public int TechnicianId { get; set; }
    }
}
