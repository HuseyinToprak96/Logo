using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Glassgn
    {
        public int Logicalref { get; set; }
        public short? Modulenr { get; set; }
        public short? Trantype { get; set; }
        public int? Tranref { get; set; }
        public int? Accref { get; set; }
        public int? Ccenterref { get; set; }
        public int? Projectref { get; set; }
        public int? Accdisttempref { get; set; }
        public string Explain { get; set; }
    }
}
