using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Configurations
{
    public class CountryCurrenciesConfigurations : IEntityTypeConfiguration<CountryCurrencies>
    {
        public void Configure(EntityTypeBuilder<CountryCurrencies> builder)
        {
            builder.HasKey(cc => new { cc.CountryId, cc.CurrencyId });
            builder.HasOne(pt => pt.Country)
                .WithMany(p => p.Currency)
                .HasForeignKey(pt => pt.CountryId);

            builder.HasOne(pt => pt.Currency)
                .WithMany(t => t.Countries)
                .HasForeignKey(pt => pt.CurrencyId);
        }
    }
}
