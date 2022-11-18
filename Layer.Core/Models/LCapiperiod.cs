using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LCapiperiod
    {
        public int Logicalref { get; set; }
        public short? Nr { get; set; }
        public short? Firmnr { get; set; }
        public DateTime? Begdate { get; set; }
        public DateTime? Enddate { get; set; }
        public short? Active { get; set; }
        public short? Key1 { get; set; }
        public short? Key2 { get; set; }
        public short? Key3 { get; set; }
        public short? Key4 { get; set; }
        public short? Perlocalctype { get; set; }
        public short? Perrepcurr { get; set; }
    }
}
