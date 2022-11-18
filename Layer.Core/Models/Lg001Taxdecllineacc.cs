using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Taxdecllineacc
    {
        public int Logicalref { get; set; }
        public int? Taxdeclhdref { get; set; }
        public int? Taxdecllnref { get; set; }
        public int? Accountref { get; set; }
        public short? Fieldnr { get; set; }
        public short? Issubacc { get; set; }
    }
}
