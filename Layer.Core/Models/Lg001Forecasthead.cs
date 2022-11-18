using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Forecasthead
    {
        public int Logicalref { get; set; }
        public string Code { get; set; }
        public string Definition { get; set; }
        public string Specode { get; set; }
        public string Cyphcode { get; set; }
        public DateTime? Rundate { get; set; }
        public short? Userno { get; set; }
        public DateTime? Begdate { get; set; }
        public DateTime? Enddate { get; set; }
        public short? Active { get; set; }
        public short? Sourcetype { get; set; }
        public short? Periodtype { get; set; }
        public short? Grouptype { get; set; }
        public short? Amounttype { get; set; }
        public short? Grpvariant { get; set; }
        public short? Correction { get; set; }
        public short? Extcount { get; set; }
        public short? Cyclecount { get; set; }
    }
}
