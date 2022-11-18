using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Vrntgenericinf
    {
        public int Logicalref { get; set; }
        public short? Typ { get; set; }
        public int? Cardref { get; set; }
        public int? Itemref { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public byte[] Ldata { get; set; }
    }
}
