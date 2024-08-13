namespace LIMS.Application.Responses
{
    public class CalibrationRecordResponse : BaseResponse
    {
        public Technician Technician { get; set; }
        public DateTime CalibrationDate { get; set; }
        public DateTime CalibrationDueDate { get; set; }
        public string Result { get; set; }
        public string Notes { get; set; }
    }
}
