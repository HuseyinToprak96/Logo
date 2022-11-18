using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Autoctemplate
    {
        public int Logicalref { get; set; }
        public short? Typ { get; set; }
        public int? Itemref { get; set; }
        public short? Increment { get; set; }
        public int? Charref { get; set; }
        public short? Length { get; set; }
        public string Sstart { get; set; }
        public string Send { get; set; }
        public int? Charvalref { get; set; }
        public string Charabbrev { get; set; }
        public short? Linenr { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
    }
}
