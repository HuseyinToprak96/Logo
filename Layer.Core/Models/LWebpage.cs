using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LWebpage
    {
        public int Logicalref { get; set; }
        public short? Firmnr { get; set; }
        public short? Status { get; set; }
        public short? Fintabusage { get; set; }
        public short? Commusage { get; set; }
        public short? Refusage { get; set; }
        public short? Itemusage { get; set; }
        public short? Annusage { get; set; }
        public short? Campusage { get; set; }
        public short? Imageinc { get; set; }
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
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public int? Wfstatus { get; set; }
        public string Subdomainname { get; set; }
        public string Firminfo { get; set; }
        public string Taxnr { get; set; }
    }
}
