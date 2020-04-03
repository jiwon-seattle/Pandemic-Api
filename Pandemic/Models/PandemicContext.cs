using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
using System;

namespace Pandemic.Models
{
    public class PandemicContext : DbContext
    {
        public PandemicContext(DbContextOptions<PandemicContext> options)
            : base(options)
        {
        }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {   
        //     optionsBuilder.UseLazyLoadingProxies();
        // }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Status> Statuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          base.OnModelCreating(modelBuilder);
          modelBuilder.Entity<Country>().HasData(
          new Country {CountryId = 1, CountryName = "Korea", },
          new Country {CountryId = 2, CountryName = "Spain", Lat = 40, Lon = -4,},
          new Country {CountryId = 3, CountryName = "USA",},
          new Country {CountryId = 4, CountryName = "Mexico",},
          new Country {CountryId = 5, CountryName = "Japan",}
          );

          modelBuilder.Entity<Status>().HasData(
          new Status {StatusId = 1, CountryId = 1, Cases = 10, Confirmed =true, Date = DateTime.Parse("4/3/2020")},
          new Status {StatusId = 2, CountryId = 2, Cases = 30, Confirmed =true, Date = DateTime.Parse("4/3/2020")},
          new Status {StatusId = 3, CountryId = 3, Cases = 50, Confirmed =true, Date = DateTime.Parse("4/3/2020")},
          new Status {StatusId = 4, CountryId = 4, Cases = 26, Confirmed =true, Date = DateTime.Parse("4/3/2020")},
          new Status {StatusId = 5, CountryId = 5, Cases = 12, Confirmed =true, Date = DateTime.Parse("4/3/2020")}
          );
        }
    }

        

}