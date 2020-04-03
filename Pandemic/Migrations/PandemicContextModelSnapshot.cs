﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pandemic.Models;

namespace Pandemic.Migrations
{
    [DbContext(typeof(PandemicContext))]
    partial class PandemicContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Pandemic.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CountryName");

                    b.Property<int>("Lat");

                    b.Property<int>("Lon");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            CountryName = "Korea",
                            Lat = 0,
                            Lon = 0
                        },
                        new
                        {
                            CountryId = 2,
                            CountryName = "Spain",
                            Lat = 40,
                            Lon = -4
                        },
                        new
                        {
                            CountryId = 3,
                            CountryName = "USA",
                            Lat = 0,
                            Lon = 0
                        },
                        new
                        {
                            CountryId = 4,
                            CountryName = "Mexico",
                            Lat = 0,
                            Lon = 0
                        },
                        new
                        {
                            CountryId = 5,
                            CountryName = "Japan",
                            Lat = 0,
                            Lon = 0
                        });
                });

            modelBuilder.Entity("Pandemic.Models.Status", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cases");

                    b.Property<bool>("Confirmed");

                    b.Property<int>("CountryId");

                    b.Property<DateTime>("Date");

                    b.HasKey("StatusId");

                    b.HasIndex("CountryId");

                    b.ToTable("Statuses");

                    b.HasData(
                        new
                        {
                            StatusId = 1,
                            Cases = 10,
                            Confirmed = true,
                            CountryId = 1,
                            Date = new DateTime(2020, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            StatusId = 2,
                            Cases = 30,
                            Confirmed = true,
                            CountryId = 2,
                            Date = new DateTime(2020, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            StatusId = 3,
                            Cases = 50,
                            Confirmed = true,
                            CountryId = 3,
                            Date = new DateTime(2020, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            StatusId = 4,
                            Cases = 26,
                            Confirmed = true,
                            CountryId = 4,
                            Date = new DateTime(2020, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            StatusId = 5,
                            Cases = 12,
                            Confirmed = true,
                            CountryId = 5,
                            Date = new DateTime(2020, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Pandemic.Models.Status", b =>
                {
                    b.HasOne("Pandemic.Models.Country", "country")
                        .WithMany("Statuses")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
