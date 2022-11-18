using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Packagefiche
    {
        public int Logicalref { get; set; }
        public string Ficheno { get; set; }
        public DateTime? Date { get; set; }
        public int? Time { get; set; }
        public short? Userno { get; set; }
        public string Specode { get; set; }
        public string Explain { get; set; }
        public double? Grossweight { get; set; }
        public double? Netweight { get; set; }
        public string Cyphcode { get; set; }
        public short? Branchno { get; set; }
        public short? Departmentno { get; set; }
        public short? Factoryno { get; set; }
        public short? Invenno { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
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
        public int? Grossweightref { get; set; }
        public int? Netweightref { get; set; }
        public short? Compingredpack { get; set; }
        public short? Printcnt { get; set; }
        public DateTime? Printdate { get; set; }
    }
}
