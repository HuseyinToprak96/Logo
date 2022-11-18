using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Slsclrel
    {
        public int Logicalref { get; set; }
        public int? Salesmanref { get; set; }
        public short? Lineno { get; set; }
        public int? Clientref { get; set; }
        public DateTime? Begdate { get; set; }
        public short? Visitday { get; set; }
        public string Visitperiod { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public int? Shipref { get; set; }
        public short? Cllineno { get; set; }
    }
}
