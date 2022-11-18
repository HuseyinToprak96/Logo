using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Stlniopegging
    {
        public int Logicalref { get; set; }
        public int? Stockref { get; set; }
        public int? Outsttrref { get; set; }
        public int? Outstfcref { get; set; }
        public DateTime? Outsttrdate { get; set; }
        public int? Insttrref { get; set; }
        public int? Instfcref { get; set; }
        public DateTime? Insttrdate { get; set; }
        public short? Linenr { get; set; }
        public double? Amount { get; set; }
        public int? Variantref { get; set; }
    }
}
