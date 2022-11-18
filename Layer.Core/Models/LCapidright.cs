using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LCapidright
    {
        public int Logicalref { get; set; }
        public short? Typ { get; set; }
        public short? Owner { get; set; }
        public short? Id { get; set; }
        public short? Item { get; set; }
        public string Acskey { get; set; }
    }
}
