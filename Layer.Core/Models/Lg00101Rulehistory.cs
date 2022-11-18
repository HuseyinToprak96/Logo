using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Rulehistory
    {
        public int Logicalref { get; set; }
        public int? Approvalref { get; set; }
        public int? Ruleref { get; set; }
        public DateTime? Date { get; set; }
        public int? Time { get; set; }
        public short? Action { get; set; }
        public short? Event { get; set; }
        public short? Doctype { get; set; }
        public byte[] Ldata { get; set; }
    }
}
