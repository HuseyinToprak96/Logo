using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Spectemplate
    {
        public int Logicalref { get; set; }
        public int? Headerref { get; set; }
        public short? Doctype { get; set; }
        public short? Edoctype { get; set; }
        public string Speccode { get; set; }
        public string Templatename { get; set; }
        public byte[] Ldata { get; set; }
    }
}
