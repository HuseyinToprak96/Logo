using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Itmclsa
    {
        public int Logicalref { get; set; }
        public int? Parentref { get; set; }
        public int? Childref { get; set; }
        public short? Uplevel { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
    }
}
