using System.ComponentModel.DataAnnotations;

namespace LIMS.Domain.Models
{
    public class OrderDetails
    {
        [Key]
        public int OrderId { get; set; }
        public int InstrumentId { get; set; }
        public int LaboratoryId { get; set; }
        public int Quantity { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        [Required]
        public string OrderedBy { get; set; }
        public string AdditionalNotes { get; set; }
        public string Status { get; set; }
    }
}
