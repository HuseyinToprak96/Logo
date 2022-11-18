using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LMessageatt
    {
        public int Logicalref { get; set; }
        public int? Messageref { get; set; }
        public short? Attidx { get; set; }
        public string Filename { get; set; }
        public double? Filesize { get; set; }
        public byte[] Ldata { get; set; }
    }
}
