using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Ovhdtran
    {
        public int Logicalref { get; set; }
        public int? Prodordref { get; set; }
        public int? Workordref { get; set; }
        public int? Ovhdclnref { get; set; }
        public int? Opactivityref { get; set; }
        public short? Accounted { get; set; }
        public short? Activity { get; set; }
        public short? Trantype { get; set; }
        public DateTime? Tranbegdate { get; set; }
        public DateTime? Tranenddate { get; set; }
        public double? Amount { get; set; }
        public double? Unitcost { get; set; }
        public double? Total { get; set; }
        public double? Rdtotal { get; set; }
        public short? Createdbyact { get; set; }
        public short? Typ { get; set; }
    }
}
