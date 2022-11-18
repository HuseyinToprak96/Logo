using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Addtax
    {
        public int Logicalref { get; set; }
        public string Taxgroupid { get; set; }
        public string Taxcode { get; set; }
        public string Taxdef { get; set; }
        public short? Addtocost { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
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
        public short? Effectkdv { get; set; }
        public short? Inlinenet { get; set; }
        public string Globalcode { get; set; }
        public short? Canteffectcost { get; set; }
        public short? Multipleaddtax { get; set; }
        public short? Multipleorderno { get; set; }
    }
}
