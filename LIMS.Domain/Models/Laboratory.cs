using LIMS.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.Domain.Models
{
    public class Laboratory : BaseModel
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string ContactNumber { get; set; }
        public IEnumerable<Instrument> Instruments { get; set; }
    }
}
