using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Lnopasgn
    {
        public int Logicalref { get; set; }
        public int? Bomrevref { get; set; }
        public int? Bomlineref { get; set; }
        public int? Routingref { get; set; }
        public int? Routlineref { get; set; }
        public int? Itemref { get; set; }
        public int? Uomref { get; set; }
        public double? Amount { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public int? Wfstatus { get; set; }
    }
}
