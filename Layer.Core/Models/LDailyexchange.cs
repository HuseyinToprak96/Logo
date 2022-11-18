using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LDailyexchange
    {
        public int Lref { get; set; }
        public int? Date { get; set; }
        public short? Crtype { get; set; }
        public double? Rates1 { get; set; }
        public double? Rates2 { get; set; }
        public double? Rates3 { get; set; }
        public double? Rates4 { get; set; }
        public DateTime? Edate { get; set; }
        public string Globalid { get; set; }
        public short? Approve { get; set; }
        public int? Approvedate { get; set; }
    }
}
