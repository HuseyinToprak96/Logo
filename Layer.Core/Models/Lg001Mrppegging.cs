using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Mrppegging
    {
        public int Logicalref { get; set; }
        public short? Parenttype { get; set; }
        public int? Parentref { get; set; }
        public short? Childtype { get; set; }
        public int? Childref { get; set; }
        public int? Itemref { get; set; }
        public int? Unitref { get; set; }
        public double? Amount { get; set; }
        public int? Ordperiod { get; set; }
        public int? Headerref { get; set; }
        public int? Variantref { get; set; }
    }
}
