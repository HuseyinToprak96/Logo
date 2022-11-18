using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Uetdscargoinfo
    {
        public int Logicalref { get; set; }
        public int? Voyageref { get; set; }
        public short? Transporttype { get; set; }
        public string Loadcntrycode { get; set; }
        public string Loadcntrydef { get; set; }
        public string Loadcitycode { get; set; }
        public string Loadcitydef { get; set; }
        public string Loaddstrctcode { get; set; }
        public string Loaddstrctdef { get; set; }
        public string Unloadcntrycode { get; set; }
        public string Unloadcntrydef { get; set; }
        public string Unloadcitycode { get; set; }
        public string Unloadcitydef { get; set; }
        public string Unloaddstrctcode { get; set; }
        public string Unloaddstrctdef { get; set; }
        public DateTime? Loaddate { get; set; }
        public int? Loadtime { get; set; }
        public DateTime? Unloaddate { get; set; }
        public int? Unloadtime { get; set; }
        public string Loadtype { get; set; }
        public string Loadtypedef { get; set; }
        public double? Loadamount { get; set; }
        public string Loadunit { get; set; }
        public short? Transportmode { get; set; }
        public string Uncode { get; set; }
        public string Undef { get; set; }
        public string Sendertitle { get; set; }
        public string Sendertaxno { get; set; }
        public string Buyertitle { get; set; }
        public string Buyertaxno { get; set; }
        public string Firmcargono { get; set; }
        public string Lineexp { get; set; }
        public string Cargoid { get; set; }
        public short? Recstatus { get; set; }
        public short? Linenr { get; set; }
    }
}
