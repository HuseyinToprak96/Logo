using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LCapifactdiv
    {
        public int Logicalref { get; set; }
        public short? Firmnr { get; set; }
        public short? Recnr { get; set; }
        public short? Nr { get; set; }
        public short? Factnr { get; set; }
        public string Name { get; set; }
        public int? Userext { get; set; }
        public int? Workdays { get; set; }
        public DateTime? Moddate { get; set; }
        public int? Modtime { get; set; }
        public int? Recordnr { get; set; }
    }
}
