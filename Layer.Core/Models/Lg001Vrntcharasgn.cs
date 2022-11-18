using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Vrntcharasgn
    {
        public int Logicalref { get; set; }
        public int? Itemref { get; set; }
        public int? Variantref { get; set; }
        public int? Charcoderef { get; set; }
        public int? Charvalref { get; set; }
        public short? Linenr { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public string Orglogoid { get; set; }
    }
}
