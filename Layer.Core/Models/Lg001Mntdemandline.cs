using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Mntdemandline
    {
        public int Logicalref { get; set; }
        public int? Demandficheref { get; set; }
        public int? Itemref { get; set; }
        public int? Faregref { get; set; }
        public int? Wsref { get; set; }
        public short? Mainttype { get; set; }
        public short? Linetype { get; set; }
        public short? Branch { get; set; }
        public short? Department { get; set; }
        public short? Factorynr { get; set; }
        public string Specode { get; set; }
        public string Lineexp { get; set; }
        public short? Status { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public int? Wfstatus { get; set; }
        public string Cyphcode { get; set; }
        public short? Lineno { get; set; }
        public int? Perref { get; set; }
        public DateTime? Fichedate { get; set; }
        public int? Projectref { get; set; }
        public string Guid { get; set; }
    }
}
