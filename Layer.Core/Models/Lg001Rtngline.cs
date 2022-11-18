using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Rtngline
    {
        public int Logicalref { get; set; }
        public int? Routingref { get; set; }
        public short? Lineno { get; set; }
        public int? Operationref { get; set; }
        public string Specode { get; set; }
        public short? Costrelated { get; set; }
        public short? Planrelated { get; set; }
        public int? Outitemref { get; set; }
        public string Lineexp { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public int? Wfstatus { get; set; }
    }
}
