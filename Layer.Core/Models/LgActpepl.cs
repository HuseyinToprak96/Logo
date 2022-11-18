using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LgActpepl
    {
        public int Logicalref { get; set; }
        public string Name { get; set; }
        public string Midinit { get; set; }
        public string Famname { get; set; }
        public int? Actref { get; set; }
        public string Emailaddr { get; set; }
        public int? Siteid { get; set; }
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
        public short? Recstatus { get; set; }
    }
}
