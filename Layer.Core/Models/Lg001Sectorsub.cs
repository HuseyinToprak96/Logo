using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Sectorsub
    {
        public int Logicalref { get; set; }
        public int? Mainsectorref { get; set; }
        public string Code { get; set; }
        public string Explanation { get; set; }
    }
}
