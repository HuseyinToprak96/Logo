using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Mnttemplateasgn
    {
        public int Logicalref { get; set; }
        public int? Itemref { get; set; }
        public int? Faregref { get; set; }
        public int? Templateref { get; set; }
        public DateTime? Begdate { get; set; }
        public DateTime? Enddate { get; set; }
        public short? Mntpreventive { get; set; }
        public short? Mntincidental { get; set; }
        public short? Mntperiodical { get; set; }
        public short? Factorynr { get; set; }
        public short? Priority { get; set; }
        public short? Linenr { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public string Guid { get; set; }
    }
}
