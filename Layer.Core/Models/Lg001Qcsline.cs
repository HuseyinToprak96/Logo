using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Qcsline
    {
        public int Logicalref { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? Setref { get; set; }
        public short? Qtype { get; set; }
        public string Qunit { get; set; }
        public string Toolcode { get; set; }
        public short? Controller { get; set; }
        public short? Insppoint { get; set; }
        public short? Inspfiches1 { get; set; }
        public short? Inspfiches2 { get; set; }
        public short? Inspfiches3 { get; set; }
        public string Importance { get; set; }
        public double? Frequency { get; set; }
        public double? Counter { get; set; }
        public double? Samplesize { get; set; }
        public double? Nomval { get; set; }
        public double? Minval { get; set; }
        public double? Maxval { get; set; }
        public double? Mintol { get; set; }
        public double? Maxtol { get; set; }
        public string Expline { get; set; }
        public short? Conformrate { get; set; }
        public short? Lineno { get; set; }
        public int? Toolref { get; set; }
        public double? Importanceval { get; set; }
    }
}
