using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Cashflowcard
    {
        public int Logicalref { get; set; }
        public string Repcode { get; set; }
        public string Repdesc { get; set; }
        public DateTime? Sdate { get; set; }
        public DateTime? Fdate { get; set; }
        public short? Incexptyp { get; set; }
        public short? Bankdtyp { get; set; }
        public short? Bankctyp { get; set; }
        public short? Cstchcks { get; set; }
        public short? Cstpnotes { get; set; }
        public DateTime? Date { get; set; }
        public string Brnchstrg1 { get; set; }
        public string Brnchstrg2 { get; set; }
        public string Brnchstrg3 { get; set; }
        public string Brnchstrg4 { get; set; }
        public string Brnchstrg5 { get; set; }
        public string Brnchstrcap { get; set; }
        public int? Usrnr { get; set; }
    }
}
