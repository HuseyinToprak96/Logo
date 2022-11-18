using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Opreqactivity
    {
        public int Logicalref { get; set; }
        public int? Opreqref { get; set; }
        public int? Ovhdref { get; set; }
        public string Formula { get; set; }
        public double? Amount { get; set; }
        public short? Whenhappen { get; set; }
    }
}
