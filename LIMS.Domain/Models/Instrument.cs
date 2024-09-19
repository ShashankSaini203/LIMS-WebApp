﻿using LIMS.Domain.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace LIMS.Domain.Models
{
    public class Instrument : BaseModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Manufacturer { get; set; }
        public string Model { get; set; }

        [Required]
        public DateTime PurchaseDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string AdditionalNotes { get; set; }
        public int LaboratoryId { get; set; }
        public Laboratory Laboratory { get; set; }
        public string CurrentCalibrationDate { get; set; }
        public int CalibrationRecordId { get; set; }
    }
}
