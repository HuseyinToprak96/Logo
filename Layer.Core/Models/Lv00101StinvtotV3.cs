using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lv00101StinvtotV3
    {
        public int? Stockref { get; set; }
        public short? Invenno { get; set; }
        public DateTime? Date { get; set; }
        public double? Reserved { get; set; }
        public double? Actporder { get; set; }
        public double? Actsorder { get; set; }
        public int? Variantref { get; set; }
        public short? Status { get; set; }
        public int Typ { get; set; }
        public long? Cnt { get; set; }
    }
}
