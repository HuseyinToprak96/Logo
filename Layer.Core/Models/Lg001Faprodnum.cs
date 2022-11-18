using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Faprodnum
    {
        public int Logicalref { get; set; }
        public int? Faregref { get; set; }
        public short? Year { get; set; }
        public short? Month { get; set; }
        public double? Amount { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
    }
}
