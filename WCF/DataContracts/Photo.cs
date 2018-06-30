using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF.DataContracts
{
    [DataContract]
    public class Photo
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Path { get; set; }

        [DataMember]
        public Lot Lot { get; set; }

    }
}