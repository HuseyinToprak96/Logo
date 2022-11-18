using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LShpagent
    {
        public int Logicalref { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Webaddr { get; set; }
        public string Trackingform { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string City { get; set; }
        public string Citycode { get; set; }
        public string Country { get; set; }
        public string Countrycode { get; set; }
        public string Town { get; set; }
        public string Towncode { get; set; }
        public string District { get; set; }
        public string Districtcode { get; set; }
        public string Postcode { get; set; }
        public string Telnrs1 { get; set; }
        public string Telnrs2 { get; set; }
        public string Faxnr { get; set; }
        public string Incharge { get; set; }
        public short? Clanguage { get; set; }
        public short? Firmtype { get; set; }
        public string Taxnr { get; set; }
        public string Tcno { get; set; }
        public string Definition { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
