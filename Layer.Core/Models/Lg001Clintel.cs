using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Clintel
    {
        public int Logicalref { get; set; }
        public int? Clientref { get; set; }
        public short? Linenum { get; set; }
        public string Intelline { get; set; }
    }
}
