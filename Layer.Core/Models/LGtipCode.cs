using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LGtipCode
    {
        public int Logicalref { get; set; }
        public string Code { get; set; }
        public short? Level { get; set; }
        public short? Codeempty { get; set; }
        public short? Selectable { get; set; }
        public double? Taxrate1 { get; set; }
        public double? Taxrate2 { get; set; }
        public double? Taxrate3 { get; set; }
        public double? Taxrate4 { get; set; }
        public double? Taxrate5 { get; set; }
    }
}
