using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL
{
    public class User
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public bool IsAdmin { get; set; }

        public List<int> Favourite { get; set; }

        public ICollection<Lot> Lots { get; set; }
    }
}
