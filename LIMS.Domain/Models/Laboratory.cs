﻿using LIMS.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public IEnumerable<Instrument> Instruments { get; set; }
    }
}
