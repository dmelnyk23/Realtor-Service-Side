using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF.DataContracts
{
    [DataContract]
    public class User
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Login { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public bool IsAdmin { get; set; }

        [DataMember]
        public string PhoneNumber { get; set; }

        [DataMember]
        public List<int> Favourite { get; set; }

        [DataMember]
        public ICollection<Lot> Lots { get; set; }
    }
}