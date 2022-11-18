using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Laborreq
    {
        public int Logicalref { get; set; }
        public int? Opreqref { get; set; }
        public int? Lineno { get; set; }
        public short? Group { get; set; }
        public int? Empref { get; set; }
        public double? Amount { get; set; }
    }
}
