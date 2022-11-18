using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lv00101Emuhtotv2
    {
        public int? Accountref { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public int? Debit { get; set; }
        public int? Credit { get; set; }
        public int? DebitRc { get; set; }
        public int? CreditRc { get; set; }
        public int? DebitLc { get; set; }
        public int? CreditLc { get; set; }
        public double? DebitAmnt { get; set; }
        public double? CreditAmnt { get; set; }
        public int? DebitEmu { get; set; }
        public int? CreditEmu { get; set; }
        public short? Branch { get; set; }
        public short? Department { get; set; }
        public short? Trcurr { get; set; }
        public double? Debitresrv { get; set; }
        public double? Creditresrv { get; set; }
        public double? DebitresrvRc { get; set; }
        public long? Cnt { get; set; }
    }
}
