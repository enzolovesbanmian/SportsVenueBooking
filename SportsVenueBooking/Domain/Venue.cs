namespace SportsVenueBooking.Domain
{
    public class Venue : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? Capacity { get; set; }
        public int? BookingRate { get; set; }
    }
}
