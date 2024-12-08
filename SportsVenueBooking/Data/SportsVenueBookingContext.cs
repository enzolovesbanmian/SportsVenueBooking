using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SportsVenueBooking.Configurations.Entities;
using SportsVenueBooking.Domain;

namespace SportsVenueBooking.Data
{
    public class SportsVenueBookingContext : DbContext
    {
        public SportsVenueBookingContext(DbContextOptions<SportsVenueBookingContext> options)
            : base(options)
        {
        }

        public DbSet<SportsVenueBooking.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<SportsVenueBooking.Domain.Equipment> Equipment { get; set; } = default!;
        public DbSet<SportsVenueBooking.Domain.Payment> Payment { get; set; } = default!;
        public DbSet<SportsVenueBooking.Domain.Sport> Sport { get; set; } = default!;
        public DbSet<SportsVenueBooking.Domain.Venue> Venue { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new VenueSeed()); //seed data for venue

        }

    }
}