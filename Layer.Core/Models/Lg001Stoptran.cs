using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Stoptran
    {
        public int Logicalref { get; set; }
        public int? Prodordref { get; set; }
        public int? Displineref { get; set; }
        public int? Opref { get; set; }
        public int? Wsref { get; set; }
        public int? Causeref { get; set; }
        public DateTime? Stopdate { get; set; }
        public int? Stoptime { get; set; }
        public DateTime? Startdate { get; set; }
        public int? Starttime { get; set; }
        public double? Stopduration { get; set; }
        public short? Affectscost { get; set; }
        public short? Affectsplan { get; set; }
        public string Transexp { get; set; }
        public short? Linenr { get; set; }
        public int? Wspartref { get; set; }
        public short? Activepartnum { get; set; }
    }
}
