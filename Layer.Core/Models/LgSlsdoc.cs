using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LgSlsdoc
    {
        public int Lref { get; set; }
        public short? Infotyp { get; set; }
        public int? Inforef { get; set; }
        public int? Doctyp { get; set; }
        public int? Docnr { get; set; }
        public byte[] Ldata { get; set; }
    }
}
