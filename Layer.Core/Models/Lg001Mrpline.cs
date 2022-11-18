using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Mrpline
    {
        public int Logicalref { get; set; }
        public short? Userno { get; set; }
        public short? Factno { get; set; }
        public DateTime? Rundate { get; set; }
        public short? Linetype { get; set; }
        public DateTime? Duedate { get; set; }
        public int? Paritemref { get; set; }
        public int? Itemref { get; set; }
        public int? Unitref { get; set; }
        public double? Reqamount { get; set; }
        public double? Prodamount { get; set; }
        public short? Frozen { get; set; }
        public double? Custorders { get; set; }
        public double? Userdemand { get; set; }
        public double? Unsizedamount { get; set; }
        public int? Parentlineref { get; set; }
        public int? Headerref { get; set; }
        public double? Userinven { get; set; }
        public double? Demandtotal { get; set; }
        public double? Plninvenchg { get; set; }
        public int? Bomrevref { get; set; }
        public int? Supplierref { get; set; }
        public short? Priority { get; set; }
        public int? Ordlineref { get; set; }
        public int? Variantref { get; set; }
        public int? Operationref { get; set; }
        public int? Wsref { get; set; }
        public short? Bomtype { get; set; }
    }
}
