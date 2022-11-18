using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Actovrhddist
    {
        public int Logicalref { get; set; }
        public int? Expcenterref { get; set; }
        public int? Accountref { get; set; }
        public int? Ovhdclnref { get; set; }
        public short? Linetype { get; set; }
        public int? Parentref { get; set; }
        public double? Total { get; set; }
        public double? Rdtotal { get; set; }
        public double? Realcapacity { get; set; }
        public double? Actunitcost { get; set; }
        public int? Postedprdref { get; set; }
        public double? Loadrate { get; set; }
        public short? Accounted { get; set; }
        public short? Typ { get; set; }
        public string Expcenterspecode { get; set; }
        public short? Expbranch { get; set; }
    }
}
