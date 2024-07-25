namespace LIMS.Domain.Models
{
    public class OrderDetails
    {
        public int OrderId { get; set; }
        public int InstrumentId { get; set; }
        public Instrument Instrument { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string OrderedBy { get; set; }
        public string AdditionalNotes { get; set; }
    }
}
