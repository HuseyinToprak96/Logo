using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Stdunitcost
    {
        public int Logicalref { get; set; }
        public short? Cardtype { get; set; }
        public int? Cardref { get; set; }
        public int? Periodref { get; set; }
        public short? Factorynr { get; set; }
        public double? Unitcost { get; set; }
        public double? Repunitcost { get; set; }
        public double? Trunitcost { get; set; }
        public short? Trcurr { get; set; }
        public double? Trrate { get; set; }
        public double? Reportrate { get; set; }
        public int? Lineno { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
    }
}
