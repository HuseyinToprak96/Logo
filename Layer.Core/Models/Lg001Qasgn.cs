using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Qasgn
    {
        public int Logicalref { get; set; }
        public int? Setref { get; set; }
        public int? Lineref { get; set; }
        public string Importance { get; set; }
        public double? Frequency { get; set; }
        public double? Counter { get; set; }
        public double? Samplesize { get; set; }
        public double? Nomval { get; set; }
        public double? Minval { get; set; }
        public double? Mintol { get; set; }
        public double? Maxval { get; set; }
        public double? Plustol { get; set; }
        public short? Insppoint { get; set; }
        public short? Inspfiches1 { get; set; }
        public short? Inspfiches2 { get; set; }
        public short? Inspfiches3 { get; set; }
        public int? Asgnref { get; set; }
        public int? Opitemref { get; set; }
        public short? Asgntype { get; set; }
        public int? Valref { get; set; }
        public short? Lineno { get; set; }
        public int? Revisionno { get; set; }
        public short? Conformrate { get; set; }
        public string Toolcode { get; set; }
        public short? Controller { get; set; }
        public int? Toolref { get; set; }
        public int? Orgrevno { get; set; }
        public short? Revsiteid { get; set; }
        public double? Importanceval { get; set; }
    }
}
