namespace LIMS.Domain.Models
{
    public class Instrument
    {
        public int InstrumentId { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public DateTime CalibrationDate { get; set; }
        public string AdditionalNotes { get; set; }
    }
}
