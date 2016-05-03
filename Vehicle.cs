using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Runtime.Serialization;


namespace VehicleService
{
    [DataContract(Namespace ="")]
    public class Vehicle
    {
        [DataMember(Order = 0)]
        public int Id { get; set; }

        [DataMember(Order = 1)]
        public int Year{ get; set; }

        [DataMember(Order = 2)]
        public string  Make { get; set; }

        [DataMember(Order = 3)]
        public string Model { get; set; }
    }
}