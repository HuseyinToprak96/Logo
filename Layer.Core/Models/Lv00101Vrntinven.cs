using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lv00101Vrntinven
    {
        public int Logicalref { get; set; }
        public int? Stockref { get; set; }
        public int? Invenno { get; set; }
        public int? Month { get; set; }
        public double? SalesAmount { get; set; }
        public double? SalesCashamnt { get; set; }
        public double? SalesCurramnt { get; set; }
        public double? SalesVatamnt { get; set; }
        public double? SalesDiscamnt { get; set; }
        public double? SalesRetamnt { get; set; }
        public double? PurchasesAmount { get; set; }
        public double? PurchasesCashamnt { get; set; }
        public double? PurchasesCurramnt { get; set; }
        public double? PurchasesVatamnt { get; set; }
        public double? PurchasesDiscamnt { get; set; }
        public double? PurchasesRetamnt { get; set; }
        public int? Year { get; set; }
        public int? Variantref { get; set; }
        public int Mtrlinc { get; set; }
        public short Virtualinven { get; set; }
    }
}
