using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lv00101Clfline
    {
        public int Logicalref { get; set; }
        public int? Clientref { get; set; }
        public short? Linenr { get; set; }
        public string Code { get; set; }
        public string Lineexp { get; set; }
        public int? Sourcefref { get; set; }
        public DateTime? Date { get; set; }
        public string Tranno { get; set; }
        public short? Trcode { get; set; }
        public short? Modulenr { get; set; }
        public int? Ftime { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
    }
}
