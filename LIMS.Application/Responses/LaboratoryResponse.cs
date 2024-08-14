namespace LIMS.Application.Responses
{
    public class LaboratoryResponse : BaseResponse
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string ContactNumber { get; set; }
        public IEnumerable<InstrumentResponse> Instruments { get; set; }
    }
}
