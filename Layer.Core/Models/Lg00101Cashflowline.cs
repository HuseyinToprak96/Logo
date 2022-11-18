using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Cashflowline
    {
        public int Logicalref { get; set; }
        public int? Cfcardref { get; set; }
        public short? Incexptyp { get; set; }
        public int? Clieref { get; set; }
        public DateTime? Sdate { get; set; }
        public double? Trrate { get; set; }
    }
}
