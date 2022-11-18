using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Repayplansln
    {
        public int Logicalref { get; set; }
        public int? Repayplanref { get; set; }
        public short? Lineno { get; set; }
        public string Formula { get; set; }
        public string Condition { get; set; }
        public string Day { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public double? Rndvalue { get; set; }
        public double? Discrate { get; set; }
        public double? Poscomsn { get; set; }
        public double? Pointcomsn { get; set; }
        public double? Duediffcomsn { get; set; }
        public short? Calctype { get; set; }
        public string Repayday { get; set; }
        public string Repaymonth { get; set; }
        public string Formula1 { get; set; }
        public string Formula2 { get; set; }
        public string Formula3 { get; set; }
    }
}
