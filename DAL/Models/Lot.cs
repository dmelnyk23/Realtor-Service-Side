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
        public double Square { get; set; }

        [Required]
        public int RoomsCount { get; set; }

        [Required]
        public int Flour { get; set; }

        [Required]
        public bool Apartment { get; set; }

        [Required]
        public bool IsSold { get; set; }

        [Required]
        public bool IsReserved { get; set; }

        [Required]
        public bool House { get; set; }

        public Address Address{ get; set; }

        public ICollection<Photo> Photos { get; set; }

    }
}
