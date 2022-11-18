using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LBrwsstat
    {
        public int Logicalref { get; set; }
        public short? Owner { get; set; }
        public short? Brwnr { get; set; }
        public short? Doctype { get; set; }
        public short? Activated { get; set; }
        public int? Curref { get; set; }
        public short? Idxnr { get; set; }
        public short? Stattype { get; set; }
    }
}
