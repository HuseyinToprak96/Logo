using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Suppevalcrln
    {
        public int Logicalref { get; set; }
        public int? Spevalcrref { get; set; }
        public short? Lineno { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public int? Wfstatus { get; set; }
        public short? Crtype { get; set; }
        public string Formula { get; set; }
    }
}
