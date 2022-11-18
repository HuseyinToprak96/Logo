using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LGibfaregtype
    {
        public int Logicalref { get; set; }
        public string Gibcode { get; set; }
        public string Notifno { get; set; }
        public string Itemno { get; set; }
        public string Gibdef { get; set; }
        public double? Rate { get; set; }
        public short? Year { get; set; }
    }
}
