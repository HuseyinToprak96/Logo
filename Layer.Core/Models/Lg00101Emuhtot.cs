using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Emuhtot
    {
        public int Logicalref { get; set; }
        public int? Accountref { get; set; }
        public int? Trancount { get; set; }
        public short? Tottype { get; set; }
        public short? Month { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
        public double? Debitrem { get; set; }
        public double? Creditrem { get; set; }
        public double? Debitinfl { get; set; }
        public double? Creditinfl { get; set; }
        public short? Year { get; set; }
        public short? Branch { get; set; }
        public short? Department { get; set; }
        public double? Debitresrv { get; set; }
        public double? Creditresrv { get; set; }
        public short? Currtyp { get; set; }
    }
}
