using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lv00101StinvtotV4
    {
        public int? Stockref { get; set; }
        public short? Invenno { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? Dordgodate { get; set; }
        public DateTime? Dordreturndate { get; set; }
        public double? Distreserved1 { get; set; }
        public int? Onvehicle1 { get; set; }
        public double? Distreserved2 { get; set; }
        public double? Onvehicle2 { get; set; }
        public int? Distreserved3 { get; set; }
        public double? Onvehicle3 { get; set; }
        public int? Variantref { get; set; }
        public int Typ { get; set; }
        public long? Cnt { get; set; }
    }
}
