using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lv00101Srvnum
    {
        public int Logicalref { get; set; }
        public int? Cardref { get; set; }
        public int? Invenno { get; set; }
        public int? Duration { get; set; }
        public double? Ordered { get; set; }
        public double? Shipped { get; set; }
        public DateTime? Lasttrdate { get; set; }
    }
}
