using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Repayplan
    {
        public int Logicalref { get; set; }
        public short? Priority { get; set; }
        public short? Dealingtype { get; set; }
        public DateTime? Begdate { get; set; }
        public DateTime? Enddate { get; set; }
        public string Firstpayterm { get; set; }
        public string Rempayterm { get; set; }
        public int? Bankaccref { get; set; }
        public double? Poscomsn { get; set; }
        public double? Pointcomsn { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicalref { get; set; }
    }
}
