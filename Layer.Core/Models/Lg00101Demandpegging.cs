using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Demandpegging
    {
        public int Logicalref { get; set; }
        public int? Demandlineref { get; set; }
        public int? Demandficheref { get; set; }
        public short? Parenttype { get; set; }
        public int? Parentref { get; set; }
        public short? Childtype { get; set; }
        public int? Childref { get; set; }
        public short? Itemalter { get; set; }
        public int? Itemref { get; set; }
        public int? Unitref { get; set; }
        public int? Mainitemref { get; set; }
        public int? Mainunitref { get; set; }
        public double? Meetamnt { get; set; }
        public double? Mainmeetamnt { get; set; }
        public int? Ordperiod { get; set; }
        public int? Clientref { get; set; }
        public int? Bommasterref { get; set; }
        public int? Bomrevref { get; set; }
        public short? Linetype { get; set; }
        public short? Detline { get; set; }
        public int? Prevlineref { get; set; }
        public short? Prevlineno { get; set; }
        public short? Lineno { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public int? Payplanref { get; set; }
        public double? Price { get; set; }
        public int? Projectref { get; set; }
        public int? Variantref { get; set; }
        public int? Mainvariantref { get; set; }
        public short? Fichetype { get; set; }
        public short? Bomtype { get; set; }
    }
}
