using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Stdcost
    {
        public int Logicalref { get; set; }
        public short? Restype { get; set; }
        public int? Resref { get; set; }
        public DateTime? Begdate { get; set; }
        public int? Unitref { get; set; }
        public double? Hourlystdcost { get; set; }
        public double? Hourlystdrpcost { get; set; }
        public short? Approved { get; set; }
        public short? Active { get; set; }
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
    }
}
