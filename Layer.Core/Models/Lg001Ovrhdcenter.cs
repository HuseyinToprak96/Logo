using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Ovrhdcenter
    {
        public int Logicalref { get; set; }
        public string Code { get; set; }
        public string Definition { get; set; }
        public string Specode { get; set; }
        public string Cyphcode { get; set; }
        public int? Expcenterref { get; set; }
        public short? Centertype { get; set; }
        public short? Cpctydriver { get; set; }
        public short? Active { get; set; }
        public double? Distrate { get; set; }
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
        public short? Textinc { get; set; }
        public int? Wfstatus { get; set; }
        public short? Printcnt { get; set; }
        public string Guid { get; set; }
        public DateTime? Printdate { get; set; }
        public string Expcenterspecode { get; set; }
        public short? Expbranch { get; set; }
    }
}
