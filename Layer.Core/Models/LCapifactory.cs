using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LCapifactory
    {
        public int Logicalref { get; set; }
        public short? Firmnr { get; set; }
        public short? Nr { get; set; }
        public string Name { get; set; }
        public short? Divisnr { get; set; }
        public short? Siteid { get; set; }
        public int? Userext { get; set; }
        public DateTime? Moddate { get; set; }
        public int? Modtime { get; set; }
    }
}
