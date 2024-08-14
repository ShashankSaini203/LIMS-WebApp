namespace LIMS.Application.Responses
{
    public class CalibrationRecordResponse : BaseResponse
    {
        public TechnicianResponse Technician { get; set; }
        public DateTime CalibrationDate { get; set; }
        public DateTime CalibrationDueDate { get; set; }
        public string Result { get; set; }
        public string Notes { get; set; }
    }
}
