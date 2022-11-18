using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Srvtot
    {
        public int Logicalref { get; set; }
        public int? Cardref { get; set; }
        public short? Invenno { get; set; }
        public short? Month { get; set; }
        public double? TotalsAmount { get; set; }
        public double? TotalsCashamnt { get; set; }
        public double? TotalsCurramnt { get; set; }
        public double? TotalsVatamnt { get; set; }
        public double? TotalsDiscamnt { get; set; }
        public double? TotalsRetamnt { get; set; }
        public short? Year { get; set; }
    }
}
