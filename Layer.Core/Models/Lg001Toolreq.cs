using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Toolreq
    {
        public int Logicalref { get; set; }
        public int? Opreqref { get; set; }
        public int? Lineno { get; set; }
        public int? Toolref { get; set; }
        public double? Amount { get; set; }
        public int? Uomref { get; set; }
        public short? Tooltype { get; set; }
        public int? Revref { get; set; }
        public int? Operationref { get; set; }
    }
}
