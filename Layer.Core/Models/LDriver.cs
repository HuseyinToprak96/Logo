using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LDriver
    {
        public int Logicalref { get; set; }
        public string Tcno { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Platenum { get; set; }
        public string Chassisnum { get; set; }
    }
}
