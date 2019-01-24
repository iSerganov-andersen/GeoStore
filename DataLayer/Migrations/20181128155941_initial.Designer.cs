﻿// <auto-generated />
using System;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataLayer.Migrations
{
    [DbContext(typeof(GeoStoreContext))]
    [Migration("20181128155941_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-preview3-35497")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataLayer.Entities.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Area");

                    b.Property<Guid>("CountryId");

                    b.Property<bool>("HasSeaPort");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<double>("Population");

                    b.HasKey("Id");

                    b.HasIndex("CountryId")
                        .IsUnique();

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("DataLayer.Entities.Country", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CallingCode");

                    b.Property<string>("CommonName");

                    b.Property<bool>("Independent");

                    b.Property<string>("InternetDomain");

                    b.Property<string>("IsoCode2")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.Property<string>("IsoCode3")
                        .IsRequired()
                        .HasMaxLength(3);

                    b.Property<bool>("LandLocked");

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<string>("OfficialName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<Guid?>("RegionId");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("DataLayer.Entities.CountryBorders", b =>
                {
                    b.Property<Guid>("CountryId");

                    b.Property<Guid>("BorderCountryId");

                    b.HasKey("CountryId", "BorderCountryId");

                    b.HasIndex("BorderCountryId");

                    b.ToTable("CountryBorders");
                });

            modelBuilder.Entity("DataLayer.Entities.CountryCurrencies", b =>
                {
                    b.Property<Guid>("CountryId");

                    b.Property<Guid>("CurrencyId");

                    b.HasKey("CountryId", "CurrencyId");

                    b.HasIndex("CurrencyId");

                    b.ToTable("CountryCurrencies");
                });

            modelBuilder.Entity("DataLayer.Entities.Currency", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(3);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("DataLayer.Entities.Region", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Area");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("DataLayer.Entities.City", b =>
                {
                    b.HasOne("DataLayer.Entities.Country", "Country")
                        .WithOne("Capital")
                        .HasForeignKey("DataLayer.Entities.City", "CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataLayer.Entities.Country", b =>
                {
                    b.HasOne("DataLayer.Entities.Region", "Region")
                        .WithMany("Countries")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataLayer.Entities.CountryBorders", b =>
                {
                    b.HasOne("DataLayer.Entities.Country", "BorderCountry")
                        .WithMany()
                        .HasForeignKey("BorderCountryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DataLayer.Entities.Country", "Country")
                        .WithMany("Borders")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataLayer.Entities.CountryCurrencies", b =>
                {
                    b.HasOne("DataLayer.Entities.Country", "Country")
                        .WithMany("Currency")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataLayer.Entities.Currency", "Currency")
                        .WithMany("Countries")
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
