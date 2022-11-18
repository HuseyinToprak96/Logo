using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LGtipDef
    {
        public int Logicalref { get; set; }
        public int? Gtipref { get; set; }
        public int? Index { get; set; }
        public string Description { get; set; }
    }
}
