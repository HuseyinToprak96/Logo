using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Packageasgn
    {
        public int Logicalref { get; set; }
        public int? Packficheref { get; set; }
        public int? Packlnref { get; set; }
        public int? Parentpacklnref { get; set; }
        public int? Itemref { get; set; }
        public int? Uomref { get; set; }
        public short? Asgnfichetype { get; set; }
        public int? Asgnficheref { get; set; }
        public int? Asgntransref { get; set; }
        public double? Amount { get; set; }
        public int? Asgnsltranref { get; set; }
        public int? Mainitemlnref { get; set; }
        public int? Variantref { get; set; }
    }
}
