using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Faexpense
    {
        public int Logicalref { get; set; }
        public int? Faregistref { get; set; }
        public int? Faexpitemref { get; set; }
        public int? Faexstfcref { get; set; }
        public int? Faexstlineref { get; set; }
        public short? Faexptyp { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public DateTime? Faexpbinddate { get; set; }
        public int? Faexpfaregref { get; set; }
        public short? Devir { get; set; }
    }
}
