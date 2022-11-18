using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LgCntslsmasg
    {
        public int Logicalref { get; set; }
        public int? Slsmref { get; set; }
        public int? Contref { get; set; }
        public string Entryid { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
    }
}
