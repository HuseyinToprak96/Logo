using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Accounttemplate
    {
        public int Logicalref { get; set; }
        public int? Accountref { get; set; }
        public short? Trcode { get; set; }
        public short? Typ { get; set; }
        public short? Lastpartlevel { get; set; }
        public string Lastcode { get; set; }
    }
}
