using DataLayer.Configurations;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataLayer
{
    public class GeoStoreContext : DbContext
    {
        public GeoStoreContext(DbContextOptions<GeoStoreContext> options) : base(options) { }
        public GeoStoreContext() { }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<CountryBorders> CountryBorders { get; set; }
        public DbSet<CountryCurrencies> CountryCurrencies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.\SQLExpress;Database=SchoolDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CityConfigurations());
            modelBuilder.ApplyConfiguration(new CountryConfigurations());
            modelBuilder.ApplyConfiguration(new CountryCurrenciesConfigurations());
            modelBuilder.ApplyConfiguration(new CountryBordersConfigurations());
            modelBuilder.ApplyConfiguration(new RegionConfigurations());
            modelBuilder.ApplyConfiguration(new CurrencyConfigurations());

            base.OnModelCreating(modelBuilder);
        }
    }
}
