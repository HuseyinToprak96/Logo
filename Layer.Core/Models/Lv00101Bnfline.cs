using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lv00101Bnfline
    {
        public int Logicalref { get; set; }
        public int? Clientref { get; set; }
        public short? Modulenr { get; set; }
        public short? Trcode { get; set; }
        public short? Bankproctype { get; set; }
        public short? Linenr { get; set; }
        public string Code { get; set; }
        public string Definition { get; set; }
        public string Lineexp { get; set; }
        public DateTime? Date { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
        public int Linetype { get; set; }
    }
}
