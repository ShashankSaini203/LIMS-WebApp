using MediatR;
using LIMS.Application.Responses;

namespace LIMS.Application.Commands.Instrument
{
    public class UpdateInstrumentCommand : IRequest<InstrumentResponse>
    {
        public int InstrumentId { get; set; }
        public string? Name { get; set; }
        public string? Manufacturer { get; set; }
        public int? Quantity { get; set; }
        public string? Model { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string? AdditionalNotes { get; set; }
        public int? LaboratoryId { get; set; }

    }
}
