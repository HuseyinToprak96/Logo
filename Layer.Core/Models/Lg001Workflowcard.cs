using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Workflowcard
    {
        public int Logicalref { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Specode { get; set; }
        public string Cyphcode { get; set; }
        public int? Workplace { get; set; }
        public short? Actiontype { get; set; }
        public short? Active { get; set; }
        public short? Priority { get; set; }
        public short? Wfusernr { get; set; }
        public int? Wfroleref { get; set; }
        public string Condition { get; set; }
        public DateTime? Begdate { get; set; }
        public DateTime? Enddate { get; set; }
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
        public int? Nextwfref { get; set; }
        public short? Statusgrpa { get; set; }
        public short? Statusgrpb { get; set; }
        public short? Statusgrpc { get; set; }
        public short? Statusgrpd { get; set; }
        public short? Statusgrpe { get; set; }
        public short? Statusgrpf { get; set; }
        public short? Cardtype { get; set; }
        public short? Module { get; set; }
        public short? Proctype { get; set; }
        public int? Msgtempref { get; set; }
    }
}
