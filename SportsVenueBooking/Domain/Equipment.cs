using Microsoft.AspNetCore.Server.HttpSys;

namespace SportsVenueBooking.Domain
{
    public class Equipment : BaseDomainModel
    {
        public string VenueId { get; set; }
        public string EquipmentName { get; set; }
        public string EquipmentDescription { get; set; }
        public int EquipmentQty { get; set; }
        public bool EquipmentAvailibility { get; set; }
        public int EquipmentPrice { get; set; }
    }
}
