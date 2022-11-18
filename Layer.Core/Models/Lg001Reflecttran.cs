using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Reflecttran
    {
        public int Logicalref { get; set; }
        public int? Ficheref { get; set; }
        public short? Linenr { get; set; }
        public short? Perlinenr { get; set; }
        public int? Lineref { get; set; }
        public int? Exbegaccref { get; set; }
        public string Exbegacccode { get; set; }
        public int? Exendaccref { get; set; }
        public string Exendacccode { get; set; }
        public double? Exratio { get; set; }
        public int? Yhaccref { get; set; }
        public string Yhacccode { get; set; }
        public double? Yhratio { get; set; }
        public int? Inaccref { get; set; }
        public string Inacccode { get; set; }
        public double? Inratio { get; set; }
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
        public int? Projectref { get; set; }
        public int? Centerref { get; set; }
    }
}
