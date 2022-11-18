using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LEbusiness
    {
        public int Logicalref { get; set; }
        public int? Firmnr { get; set; }
        public int? Progid { get; set; }
        public int? Progserialnr { get; set; }
        public short? Profilesended { get; set; }
        public short? Profileactive { get; set; }
        public short? Companydeployed { get; set; }
        public short? Companyactive { get; set; }
        public short? Trycount { get; set; }
        public DateTime? Reminddate { get; set; }
        public int? Blastdate { get; set; }
        public short? Bweekcount { get; set; }
    }
}
