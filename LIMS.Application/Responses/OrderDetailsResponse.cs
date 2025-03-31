namespace LIMS.Application.Responses
{
    public class OrderDetailsResponse
    {
        public int OrderId { get; set; }
        public int InstrumentId { get; set; }
        public int LaboratoryId { get; set; }
        public int Quantity { get; set; }
        public string Address { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string OrderedBy { get; set; }
        public string AdditionalNotes { get; set; }
        private const string DefaultStatus = "Pending";
        public string Status => DefaultStatus;
    }
}
