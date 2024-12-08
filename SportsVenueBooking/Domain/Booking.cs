namespace SportsVenueBooking.Domain
{
    public class Booking : BaseDomainModel
    {
        public string UserId { get; set; }
        public string VenueId { get; set; }
        public DateTime BookingDate { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; } 
        public bool Status { get; set; }
    }
}
