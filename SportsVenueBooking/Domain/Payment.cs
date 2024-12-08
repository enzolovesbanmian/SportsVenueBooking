namespace SportsVenueBooking.Domain
{
    public class Payment: BaseDomainModel
    {
        public string BookingId { get; set; }
        public string Amount { get; set; }
        public bool IsApproved { get; set; }
        public DateTime PaymentDate { get; set; }

    }
}
