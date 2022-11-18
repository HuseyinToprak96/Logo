using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LGibrectype
    {
        public int Logicalref { get; set; }
        public string Gibcode { get; set; }
        public string Gibdef { get; set; }
        public short? Fctype { get; set; }
        public short? Subrecusetype { get; set; }
        public int? Constsubrectypref { get; set; }
    }
}
