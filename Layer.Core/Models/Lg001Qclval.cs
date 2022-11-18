using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Qclval
    {
        public int Logicalref { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? Setref { get; set; }
        public int? Lineref { get; set; }
        public short? Targetflag { get; set; }
        public short? Textinc { get; set; }
        public short? Lineno { get; set; }
    }
}
