using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Bncard
    {
        public int Logicalref { get; set; }
        public short? Active { get; set; }
        public string Code { get; set; }
        public string Definition { get; set; }
        public string Branch { get; set; }
        public string Specode { get; set; }
        public string Cyphcode { get; set; }
        public string Branchno { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Postcode { get; set; }
        public string Telnrs1 { get; set; }
        public string Telnrs2 { get; set; }
        public string Faxnr { get; set; }
        public string Incharge { get; set; }
        public string Emailaddr { get; set; }
        public string Webaddr { get; set; }
        public short? Textinc { get; set; }
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
        public int? Wfstatus { get; set; }
        public string Cntrycode { get; set; }
        public string Town { get; set; }
        public string District { get; set; }
        public string Corrpacc { get; set; }
        public string Voen { get; set; }
        public string Guid { get; set; }
    }
}
