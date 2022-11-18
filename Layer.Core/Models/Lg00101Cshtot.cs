using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Cshtot
    {
        public int Logicalref { get; set; }
        public int? Cardref { get; set; }
        public short? Tottype { get; set; }
        public short? Day { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
        public DateTime? Date { get; set; }
        public short? Currtyp { get; set; }
    }
}
