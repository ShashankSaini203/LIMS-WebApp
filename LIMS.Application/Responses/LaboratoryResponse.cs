namespace LIMS.Application.Responses
{
    public class LaboratoryResponse
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string ContactNumber { get; set; }
        public ICollection<InstrumentResponse> Instruments { get; set; }
    }
}
