using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Uetdsvoyage
    {
        public int Logicalref { get; set; }
        public string Platenr1 { get; set; }
        public string Drivertcno1 { get; set; }
        public string Platenr2 { get; set; }
        public string Drivertcno2 { get; set; }
        public DateTime? Voyagebegdate { get; set; }
        public int? Voyagebegtime { get; set; }
        public DateTime? Voyageenddate { get; set; }
        public int? Voyageendtime { get; set; }
        public string Firmvoyageno { get; set; }
        public string Voyageid { get; set; }
        public short? Recstatus { get; set; }
        public string Genexp { get; set; }
        public short? CapiblockCreatedby { get; set; }
        public DateTime? CapiblockCreadeddate { get; set; }
        public short? CapiblockCreatedhour { get; set; }
        public short? CapiblockCreatedmin { get; set; }
        public short? CapiblockCreatedsec { get; set; }
        public short? CapiblockModifiedby { get; set; }
        public DateTime? CapiblockModifieddate { get; set; }
        public short? CapiblockModifiedhour { get; set; }
        public short? CapiblockModifiedmin { get; set; }
        public short? CapiblockModifiedsec { get; set; }
    }
}
