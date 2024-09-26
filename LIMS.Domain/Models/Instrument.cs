using System.ComponentModel.DataAnnotations;

namespace LIMS.Domain.Models
{
    public class Instrument
    {

        [Key]
        public int InstrumentId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Manufacturer { get; set; }
        public int Quantity { get; set; }
        public string Model { get; set; }

        [Required]
        public DateTime PurchaseDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string AdditionalNotes { get; set; }

        [Required]
        public int LaboratoryId { get; set; }
    }
}
