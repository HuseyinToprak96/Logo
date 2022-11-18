using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Addtaxline
    {
        public int Logicalref { get; set; }
        public int? Addtaxref { get; set; }
        public DateTime? Begdate { get; set; }
        public short? Taxtype { get; set; }
        public double? Rate { get; set; }
        public double? Amount { get; set; }
        public short? Unittype { get; set; }
        public int? Unitsetref { get; set; }
        public int? Unitref { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public double? Discamount { get; set; }
        public double? Exceptrate { get; set; }
        public double? Exceptamount { get; set; }
        public double? Collectrate { get; set; }
        public double? Collectamount { get; set; }
        public string Fcspecode { get; set; }
        public string Trspecode { get; set; }
        public string Trspecode2 { get; set; }
    }
}
