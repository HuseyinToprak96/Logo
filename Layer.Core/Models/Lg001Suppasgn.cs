using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Suppasgn
    {
        public int Logicalref { get; set; }
        public int? Itemref { get; set; }
        public short? Supplytype { get; set; }
        public short? Priority { get; set; }
        public short? Linenr { get; set; }
        public int? Clientref { get; set; }
        public string Tradinggrp { get; set; }
        public short? Clcardtype { get; set; }
        public short? Kkkcheck { get; set; }
        public double? Leadtime { get; set; }
        public double? Maxquantity { get; set; }
        public double? Minquantity { get; set; }
        public DateTime? Begdate { get; set; }
        public short? Specialized { get; set; }
        public string Icustsupcode { get; set; }
        public string Icustsupname { get; set; }
        public double? Qtydepleadtime { get; set; }
        public int? Packetref { get; set; }
        public double? Packagingamnt { get; set; }
        public int? Packaginguomref { get; set; }
        public short? Packetusetype { get; set; }
        public double? Ordperc { get; set; }
        public short? Ordfreq { get; set; }
        public int? Variantref { get; set; }
        public string Icustsupbarcode { get; set; }
    }
}
