namespace LIMS.Application.Responses
{
    public class InstrumentResponse
    {
        public int InstrumentId { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string AdditionalNotes { get; set; }
        public string LaboratoryId { get; set; }
    }
}
