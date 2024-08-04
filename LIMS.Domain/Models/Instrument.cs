using LIMS.Domain.Models.Base;

namespace LIMS.Domain.Models
{
    public class Instrument : BaseModel
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public CalibrationRecord CalibrationRecord{ get; set; }
        public string AdditionalNotes { get; set; }
    }
}
