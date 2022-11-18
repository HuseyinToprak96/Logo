using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lv00101Clcard
    {
        public int Logicalref { get; set; }
        public string Code { get; set; }
        public string Definition { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public short? Active { get; set; }
        public short? Cardtype { get; set; }
        public string Specode { get; set; }
        public string Tradinggrp { get; set; }
        public string Cyphcode { get; set; }
        public string Incharge { get; set; }
        public string Specode2 { get; set; }
        public string Specode3 { get; set; }
        public string Specode4 { get; set; }
        public string Specode5 { get; set; }
        public string Taxoffice { get; set; }
        public string Taxnr { get; set; }
        public string Tckno { get; set; }
        public string Emailaddr { get; set; }
        public string Telnrs1 { get; set; }
        public string Telnrs2 { get; set; }
        public int? Orglogicref { get; set; }
        public int? Wflowcrdref { get; set; }
        public short? Purchbrws { get; set; }
        public short? Salesbrws { get; set; }
        public short? Finbrws { get; set; }
        public string Wflowcrd { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
        public double? DebitRd { get; set; }
        public double? CreditRd { get; set; }
    }
}
