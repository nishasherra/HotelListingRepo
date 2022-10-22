using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext:DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {
             
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                { 
                    Id = 1,
                    Name="India",
                    ShortName = "IN"
                },
                new Country
                {
                    Id = 2,
                    Name = "United States of America",
                    ShortName = "USA"
                },
                new Country
                {
                    Id = 3,
                    Name = "United Arab Emirates",
                    ShortName = "UAE"
                });

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name="Mariott",
                    CountryId = 2,
                    Rating = 4.8,
                    Address = "Marion, IA"                   
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Taj",
                    CountryId = 1,
                    Rating = 5,
                    Address = "Mumbai"
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Jebel Ali Golf Resort and Spa",
                    CountryId = 3,
                    Rating = 5,
                    Address = "Dubai"
                });
        }
    }
}
