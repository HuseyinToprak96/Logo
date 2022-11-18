using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Prvopasg
    {
        public int Logicalref { get; set; }
        public int? Routingref { get; set; }
        public int? Routlineref { get; set; }
        public int? Lineopref { get; set; }
        public int? Prevopref { get; set; }
        public double? Overlapper { get; set; }
        public short? Overlaptype { get; set; }
        public double? Overlapamnt { get; set; }
        public short? Overlapmethod { get; set; }
    }
}
