using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Bomline
    {
        public int Logicalref { get; set; }
        public int? Bomrevref { get; set; }
        public short? Linetype { get; set; }
        public short? Lineno { get; set; }
        public int? Outitemref { get; set; }
        public int? Itemref { get; set; }
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
        public double? Amount { get; set; }
        public double? Scrapfact { get; set; }
        public short? Scrapcalc { get; set; }
        public short? Scalable { get; set; }
        public short? Altitemuse { get; set; }
        public short? Tempinuse { get; set; }
        public int? Nextlevelbomref { get; set; }
        public string Specode { get; set; }
        public string Bomlineexp { get; set; }
        public short? Invenno { get; set; }
        public short? Engineering { get; set; }
        public short? Production { get; set; }
        public short? Cost { get; set; }
        public double? Costrate { get; set; }
        public string Formula { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public int? Wfstatus { get; set; }
        public int? Bommasterref { get; set; }
        public short? Lineclstype { get; set; }
        public short? Detline { get; set; }
        public int? Prevlineref { get; set; }
        public int? Routlineref { get; set; }
        public int? Operationref { get; set; }
        public int? Formulaitemref { get; set; }
        public int? Nextlevrevref { get; set; }
        public short? Effectoptime { get; set; }
        public int? Dref { get; set; }
        public short? Bydefaultexists { get; set; }
        public double? Grossuinfo1 { get; set; }
        public double? Grossuinfo2 { get; set; }
        public short? Usestdcost { get; set; }
        public short? Overlapwith { get; set; }
        public short? Overlapmethod { get; set; }
        public short? Overlaptype { get; set; }
        public double? Overlapvalue { get; set; }
        public short? Overlapunit { get; set; }
        public short? Bomtype { get; set; }
        public short? Nextlevbomtype { get; set; }
        public int? Variantref { get; set; }
        public short? Optional { get; set; }
        public short? Defcosttype { get; set; }
    }
}
