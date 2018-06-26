using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Photo
    {
        public int ID { get; set; }

        public string Path { get; set; }

        public Lot Lot { get; set; }

    }
}
