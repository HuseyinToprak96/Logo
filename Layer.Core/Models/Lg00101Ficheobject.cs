using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Ficheobject
    {
        public int Logicalref { get; set; }
        public int? Ficheref { get; set; }
        public short? Fichetype { get; set; }
        public short? Objecttype { get; set; }
        public byte[] Ldata { get; set; }
    }
}
