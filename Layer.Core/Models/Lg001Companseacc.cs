using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Companseacc
    {
        public int Logicalref { get; set; }
        public int? Cardref { get; set; }
        public int? Accountref { get; set; }
        public short? Trntype { get; set; }
        public short? Mirroracc { get; set; }
    }
}
