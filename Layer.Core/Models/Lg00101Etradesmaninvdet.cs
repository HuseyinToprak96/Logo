using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Etradesmaninvdet
    {
        public int Logicalref { get; set; }
        public int? Ficheref { get; set; }
        public short? Etradstatus { get; set; }
        public short? Grpcode { get; set; }
        public short? Sendmod { get; set; }
        public string Taxnr { get; set; }
        public string Tckno { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Definition { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string Citycode { get; set; }
        public string City { get; set; }
        public string Countrycode { get; set; }
        public string Country { get; set; }
        public string Postcode { get; set; }
        public string Districtcode { get; set; }
        public string District { get; set; }
        public string Towncode { get; set; }
        public string Town { get; set; }
        public string Emailaddr { get; set; }
        public short? Iscomp { get; set; }
        public short? Responsecode { get; set; }
        public short? Responsestatus { get; set; }
        public string Statusdesc { get; set; }
    }
}
