using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Itmboma
    {
        public int Logicalref { get; set; }
        public int? Itemref { get; set; }
        public int? Bomref { get; set; }
        public short? Reltype { get; set; }
        public short? Factorynr { get; set; }
        public short? Priority { get; set; }
        public short? Linenr { get; set; }
        public double? Maxquantity { get; set; }
        public double? Minquantity { get; set; }
        public DateTime? Begdate { get; set; }
        public short? Stdcostflag { get; set; }
        public short? Formrp { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public DateTime? Enddate { get; set; }
        public int? Revref { get; set; }
        public short? Bomtype { get; set; }
    }
}
