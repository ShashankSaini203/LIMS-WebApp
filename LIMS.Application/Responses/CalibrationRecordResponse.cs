namespace LIMS.Application.Responses
{
    public class CalibrationRecordResponse
    {
        public DateTime CurrentCalibrationDate { get; set; }
        public DateTime NextCalibrationDueDate { get; set; }
        public string Result { get; set; }
        public string Notes { get; set; }
        public int TechnicianId { get; set; }
    }
}
