using System.ComponentModel.DataAnnotations;

namespace LIMS.Domain.Models.Base
{
    public class BaseModel
    {
        [Required]
        public int Id { get; set; }
    }
}
