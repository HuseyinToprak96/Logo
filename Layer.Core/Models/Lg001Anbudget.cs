using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Anbudget
    {
        public int Logicalref { get; set; }
        public string Code { get; set; }
        public string Definition { get; set; }
        public string Specode { get; set; }
        public string Cyphcode { get; set; }
        public string Docode { get; set; }
        public short? Branch { get; set; }
        public short? Department { get; set; }
        public short? Status { get; set; }
        public short? Bdgttype { get; set; }
        public int? Bdgtprdref { get; set; }
        public int? Bdgtrevfcref { get; set; }
        public short? Bdgtrevno { get; set; }
        public int? Parbdgtref { get; set; }
        public int? Lowlevelcodes1 { get; set; }
        public int? Lowlevelcodes2 { get; set; }
        public int? Lowlevelcodes3 { get; set; }
        public int? Lowlevelcodes4 { get; set; }
        public int? Lowlevelcodes5 { get; set; }
        public int? Lowlevelcodes6 { get; set; }
        public int? Lowlevelcodes7 { get; set; }
        public int? Lowlevelcodes8 { get; set; }
        public int? Lowlevelcodes9 { get; set; }
        public int? Lowlevelcodes10 { get; set; }
        public double? Totaldebit { get; set; }
        public double? Totalcredit { get; set; }
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
        public int? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public string Orglogoid { get; set; }
        public short? Textinc { get; set; }
        public string Guid { get; set; }
        public short? Printcnt { get; set; }
        public DateTime? Printdate { get; set; }
    }
}
