using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Mntorderline
    {
        public int Logicalref { get; set; }
        public int? Orderficheref { get; set; }
        public short? Tmplgroupnr { get; set; }
        public string Tmplcode { get; set; }
        public string Tmplname { get; set; }
        public string Tmpldef { get; set; }
        public double? Tmplduration { get; set; }
        public short? Tmpldurationtype { get; set; }
        public int? Itemref { get; set; }
        public int? Variantref { get; set; }
        public double? Amount { get; set; }
        public int? Uomref { get; set; }
        public int? Usref { get; set; }
        public double? Uinfo1 { get; set; }
        public double? Uinfo2 { get; set; }
        public double? Uinfo3 { get; set; }
        public double? Uinfo4 { get; set; }
        public double? Uinfo5 { get; set; }
        public double? Uinfo6 { get; set; }
        public double? Uinfo7 { get; set; }
        public double? Uinfo8 { get; set; }
        public short? Usageslip { get; set; }
        public short? Branch { get; set; }
        public short? Department { get; set; }
        public short? Factorynr { get; set; }
        public short? Sourceindex { get; set; }
        public string Specode { get; set; }
        public short? Status { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public int? Wfstatus { get; set; }
        public short? Lineno { get; set; }
        public int? Perref { get; set; }
        public DateTime? Fichedate { get; set; }
        public int? Projectref { get; set; }
        public string Guid { get; set; }
        public short? Cancelled { get; set; }
        public double? Overlapper { get; set; }
    }
}
