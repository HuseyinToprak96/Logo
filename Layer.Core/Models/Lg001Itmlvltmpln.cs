using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Itmlvltmpln
    {
        public int Logicalref { get; set; }
        public int? Itmlvltmpref { get; set; }
        public short? Lineno { get; set; }
        public short? Warehouse { get; set; }
        public short? Linetype { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Vcode { get; set; }
        public string Vname { get; set; }
        public short? Exception { get; set; }
        public short? Mindays { get; set; }
        public short? Maxdays { get; set; }
        public short? Procuredays { get; set; }
        public short? Period { get; set; }
        public double? Ordercoef { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public int? Wfstatus { get; set; }
    }
}
