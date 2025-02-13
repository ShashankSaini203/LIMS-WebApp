using MediatR;
using LIMS.Application.Responses;
using System.ComponentModel.DataAnnotations;

namespace LIMS.Application.Commands.Instrument
{
    public class CreateInstrumentCommand : IRequest<InstrumentResponse>
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Quantity { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string AdditionalNotes { get; set; }
        public int LaboratoryId { get; set; }

    }
}
