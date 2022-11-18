using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Diibline
    {
        public int Logicalref { get; set; }
        public int? Diibficheref { get; set; }
        public short? Linetype { get; set; }
        public short? Lineno { get; set; }
        public string Gtipcode { get; set; }
        public int? Uomref { get; set; }
        public int? Usref { get; set; }
        public double? Amount { get; set; }
        public double? Trnet { get; set; }
        public short? Trcurr { get; set; }
        public double? Usageamount { get; set; }
        public string Lineexp { get; set; }
        public string Specode { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
    }
}
