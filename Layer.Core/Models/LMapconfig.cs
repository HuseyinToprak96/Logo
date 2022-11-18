using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LMapconfig
    {
        public int Logicalref { get; set; }
        public string Infotechid { get; set; }
        public DateTime? Creationdate { get; set; }
        public short? Warnings { get; set; }
        public short? Activated { get; set; }
    }
}
