namespace LIMS.Application.Responses
{
    public class InstrumentResponse : BaseResponse
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public CalibrationRecordResponse CalibrationRecord { get; set; }
        public string AdditionalNotes { get; set; }
    }
}
