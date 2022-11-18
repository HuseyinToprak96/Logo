using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Mntlifehist
    {
        public int Logicalref { get; set; }
        public int? Itemref { get; set; }
        public int? Faregref { get; set; }
        public int? Wsref { get; set; }
        public int? Orderficheref { get; set; }
        public DateTime? Date { get; set; }
        public short? Lifetracktype { get; set; }
        public short? Lifetype { get; set; }
        public double? Lifevalue { get; set; }
        public double? Oldusagelife { get; set; }
        public double? Newusagelife { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public string Guid { get; set; }
    }
}
