using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Inveximline
    {
        public int Logicalref { get; set; }
        public int? Invoiceref { get; set; }
        public int? Sttransref { get; set; }
        public int? Diiblineref { get; set; }
        public int? Eximcreditref { get; set; }
        public int? Prodclref { get; set; }
        public int? Customref { get; set; }
        public string Custdocno { get; set; }
        public DateTime? Custdocdate { get; set; }
        public double? Eximcrepar { get; set; }
        public double? Diibpar { get; set; }
        public short? Countrytype { get; set; }
        public int? Countryref { get; set; }
        public string Prestatdocno { get; set; }
        public string Fzoneoutdocno { get; set; }
        public int? Origincntrref { get; set; }
        public double? Ciftotal { get; set; }
        public int? Tmpalineref { get; set; }
        public double? Tmpapar { get; set; }
        public int? Tmparef { get; set; }
        public double? Linefreight { get; set; }
        public double? Lineinsurance { get; set; }
        public double? Taxrate1 { get; set; }
        public double? Taxrate2 { get; set; }
        public double? Taxrate3 { get; set; }
        public double? Taxrate4 { get; set; }
        public double? Taxrate5 { get; set; }
        public string Tracknr { get; set; }
        public int? Pckcodesref { get; set; }
        public double? Capeunit { get; set; }
        public string Gtipcode { get; set; }
    }
}
