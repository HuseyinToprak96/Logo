using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Ldxrecdelreq
    {
        public int Logicalref { get; set; }
        public short? Doctype { get; set; }
        public int? Docref { get; set; }
        public short? Doctrcode { get; set; }
        public string Docnumber { get; set; }
        public DateTime? Docdate { get; set; }
        public string Docauxcode { get; set; }
        public string Docdesc { get; set; }
        public string Arplid { get; set; }
        public string Orglogoid { get; set; }
        public int? Param1 { get; set; }
        public string Param2 { get; set; }
        public int? Param3 { get; set; }
        public string Param4 { get; set; }
    }
}
