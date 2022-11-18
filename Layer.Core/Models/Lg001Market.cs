using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Market
    {
        public int Logicalref { get; set; }
        public int? Itemref { get; set; }
        public short? Scales { get; set; }
        public short? Scalenr { get; set; }
        public short? Kdvdepnr { get; set; }
        public string Reyoncode { get; set; }
        public short? Siteid { get; set; }
        public int? Orglogicalref { get; set; }
        public short? Recstatus { get; set; }
        public string Subsgoodcode { get; set; }
    }
}
