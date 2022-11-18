using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LGibdoctype
    {
        public int Logicalref { get; set; }
        public string Gibcode { get; set; }
        public string Gibdef { get; set; }
        public short? Simplemethod { get; set; }
        public short? Idaccount { get; set; }
        public short? Selfemp { get; set; }
        public short? Fctype { get; set; }
        public short? Serialrequired { get; set; }
    }
}
