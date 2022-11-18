using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LgSlsman
    {
        public int Logicalref { get; set; }
        public string Code { get; set; }
        public string Definition { get; set; }
        public short? Cardtype { get; set; }
        public string Specode { get; set; }
        public string Cyphcode { get; set; }
        public string Position { get; set; }
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
        public short? Active { get; set; }
        public int? Siteid { get; set; }
        public int? Orglogicref { get; set; }
        public short? Userid { get; set; }
        public short? Deptid { get; set; }
        public short? Divisid { get; set; }
        public short? Firmnr { get; set; }
        public short? Recstatus { get; set; }
        public short? Typ { get; set; }
        public string Telnumber { get; set; }
    }
}
