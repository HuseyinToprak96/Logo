using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LStatusinfo
    {
        public int Logicalref { get; set; }
        public short? Infotyp { get; set; }
        public short? Nr { get; set; }
        public string Description { get; set; }
        public short? Fromwhere { get; set; }
        public byte[] Ldata { get; set; }
    }
}
