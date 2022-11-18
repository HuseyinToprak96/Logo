using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LgContspecday
    {
        public int Logicalref { get; set; }
        public int? Contref { get; set; }
        public DateTime? Specdate { get; set; }
        public int? Spedaycat { get; set; }
        public string Persnote { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
    }
}
