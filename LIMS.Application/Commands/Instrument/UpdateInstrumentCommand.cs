﻿using MediatR;
using LIMS.Application.Responses;
using System.ComponentModel.DataAnnotations;

namespace LIMS.Application.Commands.Instrument
{
    public class UpdateInstrumentCommand : IRequest<InstrumentResponse>
    {
        public string Id { get; set; }

        [Required, MinLength(3, ErrorMessage = "Name should be atleast 3 characters long")]
        public string Name { get; set; }

        [Required, MinLength(3, ErrorMessage = "Manufacturer name should be atleast 3 characters long")]
        public string Manufacturer { get; set; }
        public string Model { get; set; }

        [Required]
        public DateTime PurchaseDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string AdditionalNotes { get; set; }
    }
}
