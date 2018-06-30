using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF.Models
{
    [DataContract]
    public class Address
    {
        public int ID { get; set; }

        [DataMember]
        public string Country { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string Street { get; set; }

        [DataMember]
        public ICollection<Lot> Lots { get; set; }
    }
}