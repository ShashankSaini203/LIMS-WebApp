using System.ComponentModel.DataAnnotations;

namespace LIMS.Domain.Models
{
    public class Laboratory
    {
        [Key]
        public int LaboratoryId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public string ContactNumber { get; set; }
    }
}
