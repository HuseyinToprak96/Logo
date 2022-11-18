using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Rettaxpegg
    {
        public int Logicalref { get; set; }
        public int? Taxdeclref { get; set; }
        public short? Linenr { get; set; }
        public short? Rettype { get; set; }
        public int? Pinvref { get; set; }
        public int? Plineref { get; set; }
        public int? Sinvref { get; set; }
        public int? Slineref { get; set; }
        public int? Itemref { get; set; }
        public double? Amount { get; set; }
        public double? Total { get; set; }
        public double? Totalvat { get; set; }
        public DateTime? Pinvdate { get; set; }
        public string Pinvdocode { get; set; }
        public string Pinvficheno { get; set; }
        public int? Pperiodnr { get; set; }
        public int? Speriodnr { get; set; }
        public double? Exportvatamnt { get; set; }
        public string Custdocno { get; set; }
        public string Rettranscode { get; set; }
        public int? Uomref { get; set; }
        public int? Clientref { get; set; }
        public short? Peximfctype { get; set; }
        public short? Seximfctype { get; set; }
        public short? Plinetype { get; set; }
        public string Uploadtype { get; set; }
        public int? Docdisper { get; set; }
        public int? Docuplper { get; set; }
        public double? Smainamnt { get; set; }
        public double? Pamount { get; set; }
        public string Vregnumber { get; set; }
        public string Vidennumber { get; set; }
    }
}
