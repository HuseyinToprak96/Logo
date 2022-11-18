using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Fatran
    {
        public int Logicalref { get; set; }
        public int? Perref { get; set; }
        public int? Empgrpref { get; set; }
        public int? Faref { get; set; }
        public short? Trcode { get; set; }
        public string Ficheno { get; set; }
        public string Docode { get; set; }
        public string Specode { get; set; }
        public string Cyphcode { get; set; }
        public short? Branch { get; set; }
        public short? Factory { get; set; }
        public short? Department { get; set; }
        public short? Warehouse { get; set; }
        public string Fadepartment { get; set; }
        public double? Amount { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? Lasttrandate { get; set; }
        public DateTime? Havedate { get; set; }
        public DateTime? Plnduedate { get; set; }
        public DateTime? Duedate { get; set; }
        public short? Fastatus { get; set; }
        public string Exp { get; set; }
        public short? Isempgrp { get; set; }
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
        public int? Fatransref { get; set; }
        public double? Oldamnt { get; set; }
        public int? Groupnr { get; set; }
        public short? Linenr { get; set; }
    }
}
