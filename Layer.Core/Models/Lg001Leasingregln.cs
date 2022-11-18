using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Leasingregln
    {
        public int Logicalref { get; set; }
        public int? Leasingregref { get; set; }
        public int? Fixassetref { get; set; }
        public double? Amount { get; set; }
        public int? Uomref { get; set; }
        public string Description { get; set; }
        public short? Lineno { get; set; }
    }
}
