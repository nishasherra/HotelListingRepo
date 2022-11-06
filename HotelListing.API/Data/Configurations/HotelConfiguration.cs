using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace HotelListing.API.Data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Mariott",
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
