using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Leasingpayment
    {
        public int Logicalref { get; set; }
        public int? Ficheref { get; set; }
        public DateTime? Paymentstartdate { get; set; }
        public double? Intrate { get; set; }
        public short? Paymentcount { get; set; }
        public short? Paymentperiod { get; set; }
        public double? Vatrate { get; set; }
        public double? Cashamount { get; set; }
        public short? Interesttype { get; set; }
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
        public int? Leasingref { get; set; }
        public DateTime? Paymentenddate { get; set; }
    }
}
