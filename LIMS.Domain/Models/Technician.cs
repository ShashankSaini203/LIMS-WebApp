using LIMS.Domain.Common;
using LIMS.Domain.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace LIMS.Domain.Models
{
    public class Technician : BaseModel
    {
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }
        public Status Status { get; set; }
    }
}
