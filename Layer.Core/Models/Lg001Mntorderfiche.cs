using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Mntorderfiche
    {
        public int Logicalref { get; set; }
        public string Ficheno { get; set; }
        public DateTime? Date { get; set; }
        public int? Time { get; set; }
        public string Docode { get; set; }
        public short? Status { get; set; }
        public string Specode { get; set; }
        public string Cyphcode { get; set; }
        public short? Branch { get; set; }
        public short? Department { get; set; }
        public short? Factorynr { get; set; }
        public short? Sourceindex { get; set; }
        public string Genexp1 { get; set; }
        public int? Demandlref { get; set; }
        public int? Maintitemref { get; set; }
        public int? Maintfaregref { get; set; }
        public int? Maintwsref { get; set; }
        public short? Mainttype { get; set; }
        public short? Maintitemtype { get; set; }
        public int? Mainttmplref { get; set; }
        public double? Maintduration { get; set; }
        public short? Maintdurationtype { get; set; }
        public DateTime? Plnbegdate { get; set; }
        public int? Plnbegtime { get; set; }
        public DateTime? Plnenddate { get; set; }
        public int? Plnendtime { get; set; }
        public DateTime? Actbegdate { get; set; }
        public int? Actbegtime { get; set; }
        public DateTime? Actenddate { get; set; }
        public int? Actendtime { get; set; }
        public short? Isexpense { get; set; }
        public double? Actmtrlcost { get; set; }
        public double? Actsrvcost { get; set; }
        public double? Actempcost { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public int? Wfstatus { get; set; }
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
        public short? Printcnt { get; set; }
        public short? Textinc { get; set; }
        public int? Wflowcrdref { get; set; }
        public int? Projectref { get; set; }
        public int? Perref { get; set; }
        public string Guid { get; set; }
        public DateTime? Printdate { get; set; }
        public short? Approve { get; set; }
        public DateTime? Approvedate { get; set; }
        public short? Cancelled { get; set; }
        public double? Actmtrlrpcost { get; set; }
        public double? Actsrvrpcost { get; set; }
        public double? Actemprpcost { get; set; }
    }
}
