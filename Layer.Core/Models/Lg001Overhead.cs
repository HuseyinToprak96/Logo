using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Overhead
    {
        public int Logicalref { get; set; }
        public string Code { get; set; }
        public string Definition { get; set; }
        public string Specode { get; set; }
        public string Cyphcode { get; set; }
        public string Unitcode { get; set; }
        public short? Active { get; set; }
        public short? Activity { get; set; }
        public int? Reflectaccref { get; set; }
        public int? Budgetdifaccref { get; set; }
        public int? Cpctydifaccref { get; set; }
        public int? Prdctvdifaccref { get; set; }
        public int? Reflectcenter { get; set; }
        public int? Budgetcenter { get; set; }
        public int? Cpctycenter { get; set; }
        public int? Prdctvcenter { get; set; }
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
        public short? Grpcodenr { get; set; }
        public string Guid { get; set; }
    }
}
