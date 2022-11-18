using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Shfttime
    {
        public int Logicalref { get; set; }
        public int? Shiftref { get; set; }
        public int? Begtime { get; set; }
        public int? Endtime { get; set; }
        public int? Siteid { get; set; }
        public int? Orglogicref { get; set; }
        public short? Recstatus { get; set; }
        public double? Costfactor { get; set; }
    }
}
