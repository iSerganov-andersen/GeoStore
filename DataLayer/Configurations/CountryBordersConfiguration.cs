using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Configurations
{
    public class CountryBordersConfigurations : IEntityTypeConfiguration<CountryBorders>
    {
        public void Configure(EntityTypeBuilder<CountryBorders> builder)
        {
            builder.HasKey(cb => new { cb.CountryId, cb.BorderCountryId });
            builder.HasOne(pt => pt.BorderCountry)
                  .WithMany()
                  .HasForeignKey(pt => pt.BorderCountryId)
                  .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(pt => pt.Country)
                .WithMany(t => t.Borders)
                .HasForeignKey(pt => pt.CountryId);
        }
    }
}
