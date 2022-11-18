using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Remindhist
    {
        public int Logicalref { get; set; }
        public int? Clientref { get; set; }
        public DateTime? Sentdate { get; set; }
        public short? Remlevel { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
        public DateTime? Paytransdate { get; set; }
        public double? Paytranstotal { get; set; }
        public int? Ficheref { get; set; }
        public int? Paytransref { get; set; }
        public int? Payplanref { get; set; }
        public short? Paytrcurr { get; set; }
        public short? Cancelled { get; set; }
    }
}
