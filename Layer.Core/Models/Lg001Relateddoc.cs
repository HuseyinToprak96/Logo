using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Relateddoc
    {
        public int Logicalref { get; set; }
        public string Doccode { get; set; }
        public string Docdef { get; set; }
        public int? Creletterref { get; set; }
        public short? Originalcnt { get; set; }
        public short? Copycnt { get; set; }
    }
}
