﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace HotelListing.API.Data.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
                new Country
                {
                    Id = 1,
                    Name = "India",
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
        }
    }
}
