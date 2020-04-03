using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Pandemic.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public int Lat { get; set; }
        public int Lon { get; set; }
        // [JsonIgnore]
        public virtual ICollection<Status> Statuses {get; set;}

        public Country()
        {
          this.Statuses = new HashSet<Status> ();
        }
    }
}