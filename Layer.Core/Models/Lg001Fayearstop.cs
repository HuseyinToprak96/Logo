using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Fayearstop
    {
        public int Logicalref { get; set; }
        public int? Faregref { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public string Explanation { get; set; }
        public short? Stopforacc { get; set; }
        public short? Stopfortax { get; set; }
        public short? Lineno { get; set; }
    }
}
