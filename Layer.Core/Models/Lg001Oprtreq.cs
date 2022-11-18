using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Oprtreq
    {
        public int Logicalref { get; set; }
        public int? Operationref { get; set; }
        public int? Lineno { get; set; }
        public short? Group { get; set; }
        public int? Wsref { get; set; }
        public DateTime? Begdate { get; set; }
        public int? Fixedsetuptime { get; set; }
        public double? Batchquantity { get; set; }
        public int? Runtime { get; set; }
        public double? Transbatchqty { get; set; }
        public int? Transbatchtime { get; set; }
        public int? Insptime { get; set; }
        public int? Quetime { get; set; }
        public int? Headtime { get; set; }
        public int? Tailtime { get; set; }
        public double? Usageper { get; set; }
        public double? Efficiency { get; set; }
        public short? Priority { get; set; }
        public double? Minamount { get; set; }
        public double? Maxamount { get; set; }
        public string Condition { get; set; }
        public double? Lineupdelay { get; set; }
        public short? Delayunit { get; set; }
        public short? Occsliceusage { get; set; }
        public int? Occslicetime { get; set; }
        public double? Waitbatchqty { get; set; }
        public int? Waitbatchtime { get; set; }
    }
}
