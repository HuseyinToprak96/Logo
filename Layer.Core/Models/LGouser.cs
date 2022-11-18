using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LGouser
    {
        public int Logicalref { get; set; }
        public short? Usrnr { get; set; }
        public short? Termnr { get; set; }
        public int? Llogindate { get; set; }
        public int? Llogintime { get; set; }
        public int? Llogoutdate { get; set; }
        public int? Llogouttime { get; set; }
        public int? Abnterms { get; set; }
        public int? Tdeferrors { get; set; }
        public string Appname { get; set; }
        public short? Firmnr { get; set; }
    }
}
