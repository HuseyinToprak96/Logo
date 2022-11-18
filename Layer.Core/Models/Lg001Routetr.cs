using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Routetr
    {
        public int Logicalref { get; set; }
        public int? Routeref { get; set; }
        public short? Lineno { get; set; }
        public int? Clientref { get; set; }
    }
}
