using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DAL
{
    public class Lot
    {
        public int ID { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public bool Flat { get; set; }

        [Required]
        public bool SingleFamilyHouse { get; set; }

        public Address Address{ get; set; }

        public ICollection<Photo> Photos { get; set; }

    }
}
