using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Cmpgnline
    {
        public int Logicalref { get; set; }
        public int? Campcardref { get; set; }
        public short? Linenr { get; set; }
        public short? Linetype { get; set; }
        public short? Applytype { get; set; }
        public string Conditemcode { get; set; }
        public string Condition { get; set; }
        public string Formula { get; set; }
        public int? Itemref { get; set; }
        public int? Usref { get; set; }
        public int? Uomref { get; set; }
        public short? Promisclass { get; set; }
        public string Lineexp { get; set; }
        public int? Accountref { get; set; }
        public int? Centerref { get; set; }
        public int? Variantref { get; set; }
        public int? Paydefref { get; set; }
    }
}
