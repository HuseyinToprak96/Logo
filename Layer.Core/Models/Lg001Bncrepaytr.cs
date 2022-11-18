using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Bncrepaytr
    {
        public int Logicalref { get; set; }
        public int? Creditref { get; set; }
        public short? Pernr { get; set; }
        public short? Transtype { get; set; }
        public int? Parentref { get; set; }
        public DateTime? Duedate { get; set; }
        public DateTime? Oprdate { get; set; }
        public short? Linenr { get; set; }
        public double? Total { get; set; }
        public double? Inttotal { get; set; }
        public double? Bsmvtotal { get; set; }
        public double? Kkdftotal { get; set; }
        public int? Bnfchref { get; set; }
        public short? Modified { get; set; }
        public int? Bnaccref { get; set; }
        public double? Trratecr { get; set; }
        public double? Trrateacc { get; set; }
        public double? Earlyintrate { get; set; }
        public double? Earlyinttot { get; set; }
        public double? Lateintrate { get; set; }
        public double? Lateinttot { get; set; }
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
        public int? Orglogicalref { get; set; }
        public short? Recstatus { get; set; }
        public int? Wfstatus { get; set; }
        public string Lineexp { get; set; }
        public double? Intrate { get; set; }
        public double? Bsmvrate { get; set; }
        public short? Fromcreditclose { get; set; }
        public string Tranlineexp { get; set; }
        public string Transpecode { get; set; }
        public double? Sintrate { get; set; }
        public double? Sbsmvrate { get; set; }
        public short? Structed { get; set; }
        public int? Bncrparentref { get; set; }
    }
}
