using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LFirmparam
    {
        public int Logicalref { get; set; }
        public short? Firmnr { get; set; }
        public short? Modulenr { get; set; }
        public short? Groupnr { get; set; }
        public string Code { get; set; }
        public string Value { get; set; }
    }
}
