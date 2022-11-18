using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LPosdef
    {
        public int Logicalref { get; set; }
        public int? Chartref { get; set; }
        public int? Workid { get; set; }
        public int? Upid { get; set; }
        public DateTime? Begdate { get; set; }
        public short? Deptnr { get; set; }
        public string Code { get; set; }
        public string Exp { get; set; }
        public short? Unitnr { get; set; }
        public short? Assistant { get; set; }
        public string Expcenter { get; set; }
    }
}
