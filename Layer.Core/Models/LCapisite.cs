using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LCapisite
    {
        public int Logicalref { get; set; }
        public short? Siteid { get; set; }
        public string Name { get; set; }
        public short? Curflg { get; set; }
        public short? Progid { get; set; }
        public int? Serial { get; set; }
        public string Licencestr { get; set; }
    }
}
