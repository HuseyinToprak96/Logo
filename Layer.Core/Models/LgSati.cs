using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LgSati
    {
        public int Logicalref { get; set; }
        public int? Userid { get; set; }
        public short? Custom { get; set; }
        public short? Itemtyp { get; set; }
        public string Itemexp { get; set; }
        public int? Parentref { get; set; }
        public short? Haschild { get; set; }
        public int? Filterref { get; set; }
    }
}
