using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LCapiwhouse
    {
        public int Logicalref { get; set; }
        public short? Firmnr { get; set; }
        public short? Nr { get; set; }
        public string Name { get; set; }
        public short? Divisnr { get; set; }
        public short? Factnr { get; set; }
        public short? Costgrp { get; set; }
        public short? Siteid { get; set; }
        public int? Userext { get; set; }
        public DateTime? Moddate { get; set; }
        public int? Modtime { get; set; }
        public short? Virtualinven { get; set; }
        public string Longitude { get; set; }
        public string Latitute { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string Towncode { get; set; }
        public string Town { get; set; }
        public string Districtcode { get; set; }
        public string District { get; set; }
        public string Citycode { get; set; }
        public string City { get; set; }
        public string Countrycode { get; set; }
        public string Country { get; set; }
        public string Telcodes1 { get; set; }
        public string Telcodes2 { get; set; }
        public string Telnrs1 { get; set; }
        public string Telnrs2 { get; set; }
        public string Telextnums1 { get; set; }
        public string Telextnums2 { get; set; }
        public string Emailaddr { get; set; }
        public string Shpagncod { get; set; }
        public short? Areacode { get; set; }
        public string Postcode { get; set; }
    }
}
