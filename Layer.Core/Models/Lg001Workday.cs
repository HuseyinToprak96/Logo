using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Workday
    {
        public int Logicalref { get; set; }
        public short? Userno { get; set; }
        public short? Factorynr { get; set; }
        public short? Factorydivnr { get; set; }
        public DateTime? Begdate { get; set; }
        public int? Begtime { get; set; }
        public int? Endtime { get; set; }
        public short? Workingday { get; set; }
        public string Explain { get; set; }
        public int? Siteid { get; set; }
        public int? Orglogicref { get; set; }
        public int? Wsref { get; set; }
        public int? Causeref { get; set; }
        public short? Restype { get; set; }
    }
}
