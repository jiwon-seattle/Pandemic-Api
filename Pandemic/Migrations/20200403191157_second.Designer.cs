﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pandemic.Models;

namespace Pandemic.Migrations
{
    [DbContext(typeof(PandemicContext))]
    [Migration("20200403191157_second")]
    partial class second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                });

            modelBuilder.Entity("Pandemic.Models.Status", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cases");

                    b.Property<bool>("Confirmed");

                    b.Property<DateTime>("Date");

                    b.Property<int>("countryId");

                    b.HasKey("StatusId");

                    b.HasIndex("countryId");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("Pandemic.Models.Status", b =>
                {
                    b.HasOne("Pandemic.Models.Country", "country")
                        .WithMany("Statuses")
                        .HasForeignKey("countryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
