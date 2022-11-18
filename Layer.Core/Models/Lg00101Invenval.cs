using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Invenval
    {
        public int Logicalref { get; set; }
        public string Ficheno { get; set; }
        public DateTime? Calcdate { get; set; }
        public short? Branch { get; set; }
        public short? Department { get; set; }
        public short? Costmethod { get; set; }
        public double? Valuedec { get; set; }
        public double? Valueinc { get; set; }
        public int? Debitaccref { get; set; }
        public int? Creditaccref { get; set; }
        public int? Crossaccref { get; set; }
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
