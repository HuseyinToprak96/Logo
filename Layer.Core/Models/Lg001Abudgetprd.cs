using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Abudgetprd
    {
        public int Logicalref { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime? Begdate { get; set; }
        public DateTime? Enddate { get; set; }
        public short? Approved { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public int? Subprdnum { get; set; }
        public short? Subprdtype { get; set; }
        public string Orglogoid { get; set; }
    }
}
