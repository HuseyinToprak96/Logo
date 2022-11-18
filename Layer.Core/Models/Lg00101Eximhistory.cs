using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Eximhistory
    {
        public int Logicalref { get; set; }
        public int? Eximinforef { get; set; }
        public short? Sourcetype { get; set; }
        public int? Sourceref { get; set; }
        public short? Processnr { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public int? Wfstatus { get; set; }
    }
}
