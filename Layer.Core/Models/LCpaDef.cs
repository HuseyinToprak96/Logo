using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LCpaDef
    {
        public int Logicalref { get; set; }
        public int? Cparef { get; set; }
        public int? Index { get; set; }
        public string Description { get; set; }
        public string Scope { get; set; }
        public string Outofscope { get; set; }
        public string Alsoscope { get; set; }
    }
}
