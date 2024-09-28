namespace LIMS.Application.Responses
{
    public class OrderDetailsResponse
    {
        private const string DefaultStatus = "Pending";

        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string OrderedBy { get; set; }
        public string AdditionalNotes { get; set; }
        public string Status => DefaultStatus;
        public int Count { get; set; }
        public int InstrumentId { get; set; }
        public int LaboratoryId { get; set; }

    }
}
