using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Leasingpaymentsln
    {
        public int Logicalref { get; set; }
        public int? Ficheref { get; set; }
        public short? Linenr { get; set; }
        public DateTime? Paymentdate { get; set; }
        public double? Paymenttotal { get; set; }
        public double? Inttotal { get; set; }
        public double? Maintotal { get; set; }
        public double? Mainremained { get; set; }
        public short? Trcurr { get; set; }
        public double? Trrate { get; set; }
        public short? Bostatus { get; set; }
        public double? Vatinpaymenttotal { get; set; }
        public short? Paymenttype { get; set; }
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
        public int? Bnaccref { get; set; }
        public int? Leasingref { get; set; }
        public short? Transtype { get; set; }
        public int? Parentref { get; set; }
        public int? Bnfchref { get; set; }
        public double? Intrate { get; set; }
        public double? Npvtodayval { get; set; }
        public double? Tenancy { get; set; }
        public double? Rentobl { get; set; }
        public double? Depreciation { get; set; }
        public double? Profitloss { get; set; }
        public int? Actaccref { get; set; }
    }
}
