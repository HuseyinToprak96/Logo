using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Itemsub
    {
        public int Logicalref { get; set; }
        public int? Mainitemref { get; set; }
        public int? Subitemref { get; set; }
        public short? Lineno { get; set; }
        public short? Priority { get; set; }
        public double? Convfact1 { get; set; }
        public double? Convfact2 { get; set; }
        public double? Maxquantity { get; set; }
        public double? Minquantity { get; set; }
        public DateTime? Begdate { get; set; }
        public DateTime? Enddate { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public int? Mainvrntref { get; set; }
        public int? Subvrntref { get; set; }
        public short? Sourceindex { get; set; }
    }
}
