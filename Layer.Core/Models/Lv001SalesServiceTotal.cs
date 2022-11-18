using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lv001SalesServiceTotal
    {
        public int Period { get; set; }
        public string SrvcardCode { get; set; }
        public short InvoiceGrpcode { get; set; }
        public string InvoiceGrpcodeTipi { get; set; }
        public short? StlineCancelled { get; set; }
        public string StlineCancelledAçiklama { get; set; }
        public int? StlineYear { get; set; }
        public int? StlineQuarter { get; set; }
        public int StlineHalf { get; set; }
        public int? StlineMonth { get; set; }
        public int? StlineWeek { get; set; }
        public int? StlineDay { get; set; }
        public short? CapidivNr { get; set; }
        public short? CapideptNr { get; set; }
        public short? CapiwhouseNr { get; set; }
        public string SlsmanCode { get; set; }
        public double? StlineInputAmount { get; set; }
        public double? StlineOutputAmount { get; set; }
        public double? StlineInputPrice { get; set; }
        public double? StlineOutputPrice { get; set; }
        public double? StlineInputTotal { get; set; }
        public double? StlineOutputTotal { get; set; }
        public double? StlineInputDistcost { get; set; }
        public double? StlineOutputDistcost { get; set; }
        public double? StlineInputDistdisc { get; set; }
        public double? StlineOutputDistdisc { get; set; }
        public double? StlineInputDistexp { get; set; }
        public double? StlineOutputDistexp { get; set; }
        public double? StlineInputDistprom { get; set; }
        public double? StlineOutputDistprom { get; set; }
        public double? StlineInputVatamnt { get; set; }
        public double? StlineOutputVatamnt { get; set; }
        public double? StlineInputVatmatrah { get; set; }
        public double? StlineOutputVatmatrah { get; set; }
        public double? StlineInputOutcost { get; set; }
        public double? StlineOutputOutcost { get; set; }
        public double? StlineInputLinenet { get; set; }
        public double? StlineOutputLinenet { get; set; }
        public double? StlineInputDiffprcost { get; set; }
        public double? StlineOutputDiffprcost { get; set; }
        public double? StlineInputDiffrepprice { get; set; }
        public double? StlineOutputDiffrepprice { get; set; }
        public double? StlineInputDiffprcrcost { get; set; }
        public double? StlineOutputDiffprcrcost { get; set; }
    }
}
