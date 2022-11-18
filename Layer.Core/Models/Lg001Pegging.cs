using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Pegging
    {
        public int Logicalref { get; set; }
        public short? Pegtype { get; set; }
        public int? Pegref { get; set; }
        public short? Reltype { get; set; }
        public int? Prodordref { get; set; }
        public int? Subcontref { get; set; }
        public int? Pordficheref { get; set; }
        public int? Pordlineref { get; set; }
        public int? Itemref { get; set; }
        public double? Amount { get; set; }
        public int? Uomref { get; set; }
        public short? Canchange { get; set; }
        public int? Displineref { get; set; }
        public int? Prodlineref { get; set; }
        public int? Otherpegref { get; set; }
        public int? Periodnr { get; set; }
        public int? Mrppropref { get; set; }
        public int? Pdemficheref { get; set; }
        public int? Pdemlineref { get; set; }
        public int? Variantref { get; set; }
        public short? Fichetype { get; set; }
        public short? Prodordtyp { get; set; }
    }
}
