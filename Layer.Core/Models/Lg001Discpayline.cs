using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Discpayline
    {
        public int Logicalref { get; set; }
        public int? Payplanref { get; set; }
        public int? Paylineref { get; set; }
        public string Day { get; set; }
        public double? Discrate { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public int? Wfstatus { get; set; }
    }
}
