using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Distline
    {
        public int Logicalref { get; set; }
        public int? Disttempref { get; set; }
        public int? Itemref { get; set; }
        public double? Distfact { get; set; }
        public short? Lineno { get; set; }
        public int? Variantref { get; set; }
    }
}
