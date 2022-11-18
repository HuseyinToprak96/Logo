using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Mrpproposal
    {
        public int Logicalref { get; set; }
        public short? Proposaltype { get; set; }
        public DateTime? Proposaldate { get; set; }
        public int? Itemref { get; set; }
        public int? Unitref { get; set; }
        public double? Amount { get; set; }
        public int? Clref { get; set; }
        public int? Bomref { get; set; }
        public int? Revref { get; set; }
        public double? Peggedamount { get; set; }
        public int? Parentpropref { get; set; }
        public short? Sourcetype { get; set; }
        public int? Sourceref { get; set; }
        public short? Movedtodemand { get; set; }
        public int? Variantref { get; set; }
    }
}
