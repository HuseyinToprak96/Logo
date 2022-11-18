using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Itmwsdef
    {
        public int Logicalref { get; set; }
        public int? Itemref { get; set; }
        public int? Wsref { get; set; }
        public double? Minlevel { get; set; }
        public double? Maxlevel { get; set; }
        public double? Safelevel { get; set; }
        public short? Minlevelctrl { get; set; }
        public short? Maxlevelctrl { get; set; }
        public short? Safelevelctrl { get; set; }
    }
}
