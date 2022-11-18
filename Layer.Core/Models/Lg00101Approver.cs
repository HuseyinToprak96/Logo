using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Approver
    {
        public int Logicalref { get; set; }
        public int? Approvalref { get; set; }
        public string Username { get; set; }
        public string Explain { get; set; }
        public short? Status { get; set; }
        public DateTime? Date { get; set; }
        public int? Time { get; set; }
        public int? Userid { get; set; }
    }
}
