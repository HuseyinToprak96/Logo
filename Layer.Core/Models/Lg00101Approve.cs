using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Approve
    {
        public int Logicalref { get; set; }
        public short? Branchnr { get; set; }
        public short? Modnr { get; set; }
        public DateTime? Approvedate { get; set; }
        public short? Usertype { get; set; }
        public short? Usernr { get; set; }
    }
}
