using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AjaxDemo.Models
{
    [Table("Destinations")]
    public class Destination
    {
        [Key]
        public string Country { get; set; }
        public string City { get; set; }
        public int Id { get; set; }

        public Destination (string country, string city, int id = 0)
        {
            Id = id;
            Country = country;
            City = city;
        }

        public Destination()
        {
        }

    }
}
