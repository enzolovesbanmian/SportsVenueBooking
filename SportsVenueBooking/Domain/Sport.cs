namespace SportsVenueBooking.Domain
{
    public class Sport:  BaseDomainModel
    {
        public string SportName { get; set; }
        public string SportDesc { get; set; }
        public string VenueId { get; set; }
    }
}
