using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LBankcode
    {
        public int Logicalref { get; set; }
        public int? Cntrnr { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public string Edicode { get; set; }
        public string Bicode { get; set; }
        public string Corrpacc { get; set; }
        public string Voen { get; set; }
    }
}
