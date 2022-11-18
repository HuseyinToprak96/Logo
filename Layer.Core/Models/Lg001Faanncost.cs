using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Faanncost
    {
        public int Logicalref { get; set; }
        public int? Fregref { get; set; }
        public DateTime? Dt { get; set; }
        public double? Annval { get; set; }
        public double? Rofmval { get; set; }
        public short? Tablety { get; set; }
    }
}
