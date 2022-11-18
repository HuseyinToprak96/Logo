using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Discpaytran
    {
        public int Logicalref { get; set; }
        public int? Paytranref { get; set; }
        public int? Cardref { get; set; }
        public short? Trcode { get; set; }
        public short? Modulenr { get; set; }
        public short? Tsign { get; set; }
        public int? Ficheref { get; set; }
        public int? Fichelineref { get; set; }
        public double? Discrate { get; set; }
        public DateTime? Discduedate { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public int? Wfstatus { get; set; }
    }
}
