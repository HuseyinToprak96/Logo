using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LFrmod
    {
        public int Lref { get; set; }
        public int? Module { get; set; }
        public short? Infotype { get; set; }
        public int? Objid { get; set; }
        public int? Instid { get; set; }
        public byte[] Ldata { get; set; }
    }
}
