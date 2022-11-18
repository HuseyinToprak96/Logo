using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Srvunitum
    {
        public int Logicalref { get; set; }
        public int? Srvref { get; set; }
        public short? Linenr { get; set; }
        public int? Unitlineref { get; set; }
        public short? Priority { get; set; }
    }
}
