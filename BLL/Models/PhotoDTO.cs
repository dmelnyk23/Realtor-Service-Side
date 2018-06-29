using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class PhotoDTO
    {
        public int ID { get; set; }

        public string Path { get; set; }

        public LotDTO Lot { get; set; }

    }
}
