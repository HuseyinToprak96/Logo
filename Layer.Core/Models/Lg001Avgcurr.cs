using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Avgcurr
    {
        public int Logicalref { get; set; }
        public short? Currtype { get; set; }
        public int? Periodref { get; set; }
        public double? Avgcurrval { get; set; }
    }
}
