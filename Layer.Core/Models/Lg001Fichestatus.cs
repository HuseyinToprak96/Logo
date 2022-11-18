using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Fichestatus
    {
        public int Logicalref { get; set; }
        public short? Typ { get; set; }
        public string Name { get; set; }
        public short? Active { get; set; }
        public short? Linenr { get; set; }
    }
}
