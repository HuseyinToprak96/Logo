using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LPostcode
    {
        public int Logicalref { get; set; }
        public int? Country { get; set; }
        public int? City { get; set; }
        public string Postcode { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
    }
}
