using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Forecastline
    {
        public int Logicalref { get; set; }
        public int? Headref { get; set; }
        public short? Periodno { get; set; }
        public short? Periodcount { get; set; }
        public string Groupcode1 { get; set; }
        public string Groupcode2 { get; set; }
        public int? Stockref { get; set; }
        public int? Variantref { get; set; }
        public int? Uomref { get; set; }
        public string Uomstr { get; set; }
        public double? Prevamount { get; set; }
        public double? Amount { get; set; }
        public double? Castamount { get; set; }
        public double? Errval { get; set; }
        public short? Methodno { get; set; }
    }
}
