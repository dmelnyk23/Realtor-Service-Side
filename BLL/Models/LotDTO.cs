using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class LotDTO
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

        public AddressDTO Address { get; set; }

        public ICollection<PhotoDTO> Photos { get; set; }

        public UserDTO User { get; set; }


    }
}
