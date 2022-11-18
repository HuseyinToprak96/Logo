using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Einvoicelog
    {
        public int Logicalref { get; set; }
        public string Invfcno { get; set; }
        public DateTime? Invfcdate { get; set; }
        public string Stfcno { get; set; }
        public DateTime? Stfcdate { get; set; }
        public string Stfcnoin { get; set; }
        public int? Stfcref { get; set; }
        public string Itemcode { get; set; }
        public string Uomcode { get; set; }
        public double? Amount { get; set; }
        public int? Itemref { get; set; }
        public int? Uomref { get; set; }
        public short? Errortyp { get; set; }
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
