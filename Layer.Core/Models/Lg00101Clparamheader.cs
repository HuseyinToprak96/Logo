using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Clparamheader
    {
        public int Logicalref { get; set; }
        public string Cllogoid { get; set; }
        public short? Isdefault { get; set; }
        public short? Inactive { get; set; }
        public short? Grouped { get; set; }
        public short? Grouptype { get; set; }
        public short? Bcinitialized { get; set; }
        public short? Bcbarcodetype { get; set; }
        public short? Bccode128subset { get; set; }
        public short? Bcrotation { get; set; }
        public short? Bcshowcode { get; set; }
        public short? Bcbarwidth { get; set; }
        public int? Bcbackcolor { get; set; }
        public int? Bcbarcolor { get; set; }
        public int? Bcfontcolor { get; set; }
        public short? Cardtype { get; set; }
    }
}
