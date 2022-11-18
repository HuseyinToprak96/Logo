using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lv00101Emuhtot
    {
        public int Logicalref { get; set; }
        public int? Accountref { get; set; }
        public int Trancount { get; set; }
        public int Tottype { get; set; }
        public int? Month { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
        public int Debitrem { get; set; }
        public int Creditrem { get; set; }
        public int Debitinfl { get; set; }
        public int Creditinfl { get; set; }
        public int? Year { get; set; }
        public short? Branch { get; set; }
        public short? Department { get; set; }
        public double? Debitresrv { get; set; }
        public double? Creditresrv { get; set; }
        public int? Currtyp { get; set; }
    }
}
