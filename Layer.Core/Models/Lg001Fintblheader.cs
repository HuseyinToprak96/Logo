using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Fintblheader
    {
        public int Logicalref { get; set; }
        public short? Tabtype { get; set; }
        public string Tabname { get; set; }
        public short? Itemsz { get; set; }
        public short? Totaltyp { get; set; }
        public short? Currtyp { get; set; }
        public short? Replevel { get; set; }
        public int? Tablemult { get; set; }
        public string Tablegenexp { get; set; }
        public string Tableexp { get; set; }
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
    }
}
