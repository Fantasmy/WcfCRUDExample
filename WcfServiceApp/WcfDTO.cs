using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfServiceApp
{
    [DataContract]
    public class WcfDto
    {
        [DataMember]
        public System.Guid id { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string surname { get; set; }
        [DataMember]
        public string email { get; set; }
    }
}