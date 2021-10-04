using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTrai1.Models
{
    public class Toys
    {
        [Key]
        public int ToyId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set;}
        public string Manufacturer { get; set; }
        public string Gender { get; set; }

    }
}