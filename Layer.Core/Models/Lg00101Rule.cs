using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Rule
    {
        public int Logicalref { get; set; }
        public string Code { get; set; }
        public string Def { get; set; }
        public short? Priority { get; set; }
        public short? Doctype { get; set; }
        public short? Eventkind { get; set; }
        public short? Ruletype { get; set; }
        public short? Disabled { get; set; }
        public short? Datasourcetyp { get; set; }
        public short? Version { get; set; }
        public string Pwd { get; set; }
        public byte[] Ldata { get; set; }
    }
}
