using Microsoft.EntityFrameworkCore;


using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsVenueBooking.Domain;

using System.Drawing;

namespace SportsVenueBooking.Configurations.Entities
{
    public class VenueSeed : IEntityTypeConfiguration<Venue>
    {
        public void Configure(EntityTypeBuilder<Venue> builder)
        {
            builder.HasData(
                new Venue
                {
                    Id = 1,
                    Name = "Pasir Ris Sports Centre",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    Createdby = "System",
                    Updatedby = "System"
                },
                new Venue
                {
                    Id = 2,
                    Name = "Tampines Gym",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    Createdby = "System",
                    Updatedby = "System"
                }
                );
        }
    }
}
