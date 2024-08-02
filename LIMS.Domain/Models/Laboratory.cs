using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.Domain.Models
{
    public class Laboratory
    {
        public int LaboratoryId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string ContactNumber { get; set; }
        public List<Instrument> Instruments { get; set; }
    }
}
