using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Ascond
    {
        public int Logicalref { get; set; }
        public short? Usetype { get; set; }
        public short? Lineno { get; set; }
        public int? Cardref { get; set; }
        public short? Linetype { get; set; }
        public short? Active { get; set; }
        public short? Priority { get; set; }
        public DateTime? Begdate { get; set; }
        public DateTime? Enddate { get; set; }
        public string Stcodes { get; set; }
        public string Cicodes { get; set; }
        public string Paycodes { get; set; }
        public short? Itemtype { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
    }
}
