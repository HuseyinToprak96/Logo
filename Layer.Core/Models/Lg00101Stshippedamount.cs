using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Stshippedamount
    {
        public int Logicalref { get; set; }
        public int? Transref { get; set; }
        public int? Ordtransref { get; set; }
        public double? Shippedamount { get; set; }
        public double? Shippedrsrvamt { get; set; }
    }
}
