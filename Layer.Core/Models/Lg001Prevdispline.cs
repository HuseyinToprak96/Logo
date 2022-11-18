using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Prevdispline
    {
        public int Logicalref { get; set; }
        public int? Prodordref { get; set; }
        public int? Displineref { get; set; }
        public int? Prevlineref { get; set; }
        public double? Overlapper { get; set; }
        public short? Linenr { get; set; }
        public short? Overlaptype { get; set; }
        public double? Overlapamnt { get; set; }
        public short? Overlapmethod { get; set; }
    }
}
