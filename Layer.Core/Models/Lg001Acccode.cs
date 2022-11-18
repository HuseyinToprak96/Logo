using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Acccode
    {
        public int Logicalref { get; set; }
        public short? Modnr { get; set; }
        public byte[] Grpfilter { get; set; }
        public double? Vatrate { get; set; }
        public int? Accountref { get; set; }
        public int? Centerref { get; set; }
        public string Lineexp { get; set; }
        public string Calcformula { get; set; }
        public string Indexcode { get; set; }
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
        public short? Prevalue { get; set; }
        public short? Prdiff { get; set; }
        public int? Projectref { get; set; }
        public short? Branchnr { get; set; }
        public short? Effectivecost { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public string Specode { get; set; }
        public short? Priority { get; set; }
        public short? Month { get; set; }
        public short? Year { get; set; }
        public short? Exptype { get; set; }
    }
}
