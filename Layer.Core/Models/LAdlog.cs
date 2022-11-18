using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LAdlog
    {
        public int Logicalref { get; set; }
        public string Aduser { get; set; }
        public string Addate { get; set; }
        public string Adtime { get; set; }
        public string Admsg { get; set; }
        public string Adinfo { get; set; }
    }
}
