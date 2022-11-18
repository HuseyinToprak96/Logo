using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LgUsagestat
    {
        public int Logicalref { get; set; }
        public int? Objhashid { get; set; }
        public int? Usagecount { get; set; }
        public short? Objtype { get; set; }
        public string Objname { get; set; }
    }
}
