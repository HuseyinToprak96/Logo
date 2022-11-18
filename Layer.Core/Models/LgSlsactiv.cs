using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LgSlsactiv
    {
        public int Logicalref { get; set; }
        public DateTime? Date { get; set; }
        public int? Time { get; set; }
        public short? Acttype { get; set; }
        public int? Opporref { get; set; }
        public int? Salesmanref { get; set; }
        public int? Cstvndref { get; set; }
        public int? Actorder { get; set; }
        public string Description { get; set; }
        public short? Priority { get; set; }
        public short? Approval { get; set; }
        public DateTime? Duedate { get; set; }
        public int? Duetime { get; set; }
        public short? Sendvia { get; set; }
        public int? Sendref { get; set; }
        public string Specode { get; set; }
        public string Cyphcode { get; set; }
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
        public short? Lastrevision { get; set; }
        public short? Textinc { get; set; }
        public string Description2 { get; set; }
        public string Guid { get; set; }
    }
}
