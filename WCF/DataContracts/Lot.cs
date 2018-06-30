using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using WCF.Models;

namespace WCF.DataContracts
{
    [DataContract]
    public class Lot
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public decimal Price { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public double Square { get; set; }

        [DataMember]
        public int RoomsCount { get; set; }

        [DataMember]
        public int Flour { get; set; }

        [DataMember]
        public bool Apartment { get; set; }

        [DataMember]
        public bool IsSold { get; set; }

        [DataMember]
        public bool IsReserved { get; set; }

        [DataMember]
        public bool House { get; set; }

        [DataMember]
        public Address Address { get; set; }

        [DataMember]
        public ICollection<Photo> Photos { get; set; }

        [DataMember]
        public User User { get; set; }

    }
}