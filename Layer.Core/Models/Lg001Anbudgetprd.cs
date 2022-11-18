using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Anbudgetprd
    {
        public int Logicalref { get; set; }
        public int? Bdgtref { get; set; }
        public int? Bdgtlnref { get; set; }
        public int? Bdgtprdref { get; set; }
        public short? Prdno { get; set; }
        public DateTime? Prdbegdate { get; set; }
        public DateTime? Prdenddate { get; set; }
        public int? Accref { get; set; }
        public int? Crsaccref { get; set; }
        public int? Crsraccref { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
        public short? Branch { get; set; }
        public short? Department { get; set; }
        public int? Bdgtrevfcref { get; set; }
        public short? Bdgtrevno { get; set; }
        public int? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public string Orglogoid { get; set; }
    }
}
