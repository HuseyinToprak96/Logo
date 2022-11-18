using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Lngexcset
    {
        public int Logicalref { get; set; }
        public int? Docid { get; set; }
        public int? Docref { get; set; }
        public int? Fieldid { get; set; }
        public short? Langid { get; set; }
        public string Fieldcont { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
    }
}
