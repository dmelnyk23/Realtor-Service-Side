using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Address
    {
        public int ID { get; set; }

        [Required]
        public decimal Country { get; set; }

        [Required]
        public string City { get; set; }

        public bool Street { get; set; }

        public Lot Lot { get; set; }
    }
}
