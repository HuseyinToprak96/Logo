using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Msgtemplate
    {
        public int Logicalref { get; set; }
        public short? Msgtype { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Msgtext { get; set; }
    }
}
