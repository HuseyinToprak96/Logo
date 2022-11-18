using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LCapiprog
    {
        public int Logicalref { get; set; }
        public string Name { get; set; }
        public short? Progid { get; set; }
        public int? Serial { get; set; }
        public short? Version { get; set; }
        public short? Keychg { get; set; }
        public short? Keyperd { get; set; }
        public short? Keywarn { get; set; }
        public short? Minkeylen { get; set; }
        public short? Minalphalen { get; set; }
        public short? Minnumlen { get; set; }
        public short? Lastkeyuse { get; set; }
        public short? Typ { get; set; }
        public short? Maxfailedlogins { get; set; }
        public short? Forceuplowercase { get; set; }
        public short? Supervisorchk { get; set; }
    }
}
