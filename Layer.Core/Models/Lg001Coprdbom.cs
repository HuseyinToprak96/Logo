using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Coprdbom
    {
        public int Logicalref { get; set; }
        public int? Bommasterref { get; set; }
        public int? Bomrevref { get; set; }
        public int? Coprodref { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public int? Wfstatus { get; set; }
        public int? Coprodvrntref { get; set; }
    }
}
