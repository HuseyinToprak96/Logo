using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lv00101Orfline
    {
        public int Logicalref { get; set; }
        public int? Ordficheref { get; set; }
        public int? Stockref { get; set; }
        public short? Lineno { get; set; }
        public double? Amount { get; set; }
        public double? Price { get; set; }
        public double? Total { get; set; }
        public DateTime? Date { get; set; }
        public short? Linetype { get; set; }
        public short? Trcode { get; set; }
        public string Code { get; set; }
        public string Lineexp { get; set; }
    }
}
