using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Reflectasgn
    {
        public int Logicalref { get; set; }
        public int? Reflectref { get; set; }
        public int? Accficheref { get; set; }
        public short? Fichetype { get; set; }
        public short? Branch { get; set; }
        public DateTime? Begdate { get; set; }
        public DateTime? Enddate { get; set; }
        public short? Department { get; set; }
    }
}
