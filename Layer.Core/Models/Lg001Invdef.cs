using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Invdef
    {
        public int Logicalref { get; set; }
        public short? Invenno { get; set; }
        public int? Itemref { get; set; }
        public double? Minlevel { get; set; }
        public double? Maxlevel { get; set; }
        public double? Safelevel { get; set; }
        public int? Locationref { get; set; }
        public DateTime? Perclosedate { get; set; }
        public short? Abccode { get; set; }
        public short? Minlevelctrl { get; set; }
        public short? Maxlevelctrl { get; set; }
        public short? Safelevelctrl { get; set; }
        public short? Neglevelctrl { get; set; }
        public short? Ioctrl { get; set; }
        public int? Variantref { get; set; }
        public short? Outctrl { get; set; }
    }
}
