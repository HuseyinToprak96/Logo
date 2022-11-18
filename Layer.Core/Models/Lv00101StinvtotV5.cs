using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lv00101StinvtotV5
    {
        public int? Stockref { get; set; }
        public short? Invenno { get; set; }
        public DateTime? Date { get; set; }
        public double? Reserved { get; set; }
        public int? Actporder { get; set; }
        public int? Actsorder { get; set; }
        public int? Variantref { get; set; }
        public short? Status { get; set; }
        public int Typ { get; set; }
        public long? Cnt { get; set; }
    }
}
