using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Configurations
{
    public class CountryConfigurations : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.Property(c => c.OfficialName).IsRequired().HasMaxLength(255);
            builder.Property(c => c.IsoCode2).IsRequired().HasMaxLength(2);
            builder.Property(c => c.IsoCode3).IsRequired().HasMaxLength(3);
            builder.HasOne(p => p.Region)
                 .WithMany(r => r.Countries)
                 .OnDelete(DeleteBehavior.Cascade);


            builder.HasOne(p => p.Capital)
                  .WithOne(c => c.Country)
                  .HasForeignKey<City>(c => c.CountryId);
        }
    }
}
