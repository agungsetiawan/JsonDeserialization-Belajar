using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JsonDeserialization_Belajar
{
    [DataContract]
    public class Person
    {
        [DataMember(Name="name")]
        public string Name { get; set; }

        [DataMember(Name="email")]
        public string Email { get; set; }

        [DataMember(Name="job")]
        public string Job { get; set; }
    }
}
