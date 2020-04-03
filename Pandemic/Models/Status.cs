using System;
using System.ComponentModel.DataAnnotations;

namespace Pandemic.Models
{
    public class Status
    {
        public int StatusId { get; set; }
        public int CountryId {get; set;}
        public int Cases { get; set; }
        public bool Confirmed { get; set; }
        public DateTime Date { get; set;}
        public virtual Country Country {get; set;}

    }
}