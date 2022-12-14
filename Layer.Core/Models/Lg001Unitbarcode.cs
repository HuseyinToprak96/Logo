using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Unitbarcode
    {
        public int Logicalref { get; set; }
        public int? Itmunitaref { get; set; }
        public int? Itemref { get; set; }
        public int? Variantref { get; set; }
        public int? Unitlineref { get; set; }
        public short? Linenr { get; set; }
        public string Barcode { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public short? Typ { get; set; }
        public short? Wbarcodeshift { get; set; }
        public string Globalid { get; set; }
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
