using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Payline
    {
        public int Logicalref { get; set; }
        public int? Payplanref { get; set; }
        public short? Lineno { get; set; }
        public short? Afterdays { get; set; }
        public string Formula { get; set; }
        public string Condition { get; set; }
        public string Day { get; set; }
        public string Mounth { get; set; }
        public string Year { get; set; }
        public double? Rndvalue { get; set; }
        public DateTime? Absdate { get; set; }
        public short? Datetype { get; set; }
        public double? Discrate { get; set; }
        public short? Paymenttype { get; set; }
        public int? Bankaccref { get; set; }
        public int? Repaydefref { get; set; }
        public short? Trcurr { get; set; }
        public string Globalcode { get; set; }
    }
}
