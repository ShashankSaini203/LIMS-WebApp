using LIMS.Domain.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace LIMS.Domain.Models
{
    public class OrderDetails : BaseModel
    {
        [Required]
        public int InstrumentId { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }

        [Required]
        public string OrderedBy { get; set; }
        public string AdditionalNotes { get; set; }
        public string Status { get; set; }

    }
}
