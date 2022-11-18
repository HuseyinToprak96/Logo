using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LgNtlck000
    {
        public int Logicalref { get; set; }
        public string Lockstr { get; set; }
        public int? Counter { get; set; }
        public string Sessioncode { get; set; }
        public string Programname { get; set; }
    }
}
