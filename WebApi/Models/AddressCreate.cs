using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class AddressCreate
    {
        public string AddressLine { get; set; }
        public short? HouseNr { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
    }
}
