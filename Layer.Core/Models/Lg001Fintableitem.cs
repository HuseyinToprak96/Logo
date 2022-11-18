using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Fintableitem
    {
        public int Logicalref { get; set; }
        public short? Lineno { get; set; }
        public short? Side { get; set; }
        public short? Itemlevel { get; set; }
        public short? Calctype { get; set; }
        public short? Remtype { get; set; }
        public short? Linetype { get; set; }
        public short? Itemtype { get; set; }
        public short? Tottype { get; set; }
        public short? Acctype { get; set; }
        public short? Printinreport { get; set; }
        public short? Currtype { get; set; }
        public double? Totaltl { get; set; }
        public double? Totalcurr { get; set; }
        public string Itemname { get; set; }
        public string Itemcode { get; set; }
        public string Begcode { get; set; }
        public string Endcode { get; set; }
        public string Formula { get; set; }
        public string Rates1 { get; set; }
        public string Rates2 { get; set; }
        public string Rates3 { get; set; }
        public string Rates4 { get; set; }
        public int? Tableref { get; set; }
        public int? Taxdecllnref { get; set; }
        public short? Fieldnr { get; set; }
        public short? Taxdecltyp { get; set; }
        public string Kdv1txt { get; set; }
    }
}
