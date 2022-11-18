using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Spevallnscore
    {
        public int Logicalref { get; set; }
        public int? Spevalcrref { get; set; }
        public int? Spevalcrlnref { get; set; }
        public short? Valuetype { get; set; }
        public double? Value { get; set; }
        public double? Score { get; set; }
        public string Valuedesc { get; set; }
        public short? Lineno { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public int? Wfstatus { get; set; }
    }
}
