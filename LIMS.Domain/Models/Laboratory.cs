using LIMS.Domain.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace LIMS.Domain.Models
{
    public class Laboratory : BaseModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public string ContactNumber { get; set; }
        public ICollection<Instrument> Instruments { get; set; }
    }
}
