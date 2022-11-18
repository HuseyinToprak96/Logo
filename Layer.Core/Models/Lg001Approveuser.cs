using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Approveuser
    {
        public int Logicalref { get; set; }
        public int? Recordref { get; set; }
        public short? Recordtype { get; set; }
        public short? Usernr { get; set; }
        public short? Status { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
    }
}
