using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.Domain.Models
{
    public class CalibrationRecord
    {
        public int CalibrationRecordId { get; set; }
        public int InstrumentId { get; set; }
        public Instrument Instrument { get; set; }
        public int TechnicianId { get; set; }
        public Technician Technician { get; set; }
        public DateTime CalibrationDate { get; set; }
        public string Result { get; set; }
        public string Notes { get; set; }
    }
}
