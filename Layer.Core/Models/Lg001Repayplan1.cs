using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Repayplan1
    {
        public int Logicalref { get; set; }
        public string Code { get; set; }
        public string Definition { get; set; }
        public int? Bankaccref { get; set; }
        public DateTime? Begdate { get; set; }
        public DateTime? Enddate { get; set; }
        public string Specode { get; set; }
        public string Cyphcode { get; set; }
        public short? Wrkdays { get; set; }
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
        public short? Active { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public int? Wfstatus { get; set; }
        public double? Earlyinterest { get; set; }
        public double? Lateinterest { get; set; }
        public short? Defaultflg { get; set; }
    }
}
