using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Printlimit
    {
        public int Logicalref { get; set; }
        public int? Formid { get; set; }
        public short? Prnlimit { get; set; }
        public short? Typ { get; set; }
    }
}
