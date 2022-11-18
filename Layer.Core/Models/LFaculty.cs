using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LFaculty
    {
        public int Logicalref { get; set; }
        public short? Typ { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? Cntrnr { get; set; }
    }
}
