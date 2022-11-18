using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lv00101Clekstre
    {
        public int Logicalref { get; set; }
        public int? Clientref { get; set; }
        public int? Sourcefref { get; set; }
        public DateTime? Date { get; set; }
        public string Tranno { get; set; }
        public short? Trcode { get; set; }
        public string Lineexp { get; set; }
        public short? Modulenr { get; set; }
        public int? Ftime { get; set; }
        public double? Amount { get; set; }
        public string Cyphcode { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
        public short? Trcurr { get; set; }
        public double? Trnet { get; set; }
        public string Docode { get; set; }
        public short? Cancelled { get; set; }
    }
}
