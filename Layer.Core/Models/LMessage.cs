using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LMessage
    {
        public int Logicalref { get; set; }
        public short? Priority { get; set; }
        public short? Readflag { get; set; }
        public short? Sendedcopy { get; set; }
        public DateTime? Date { get; set; }
        public short? Fromusernr { get; set; }
        public string Fromuser { get; set; }
        public short? Tousernr { get; set; }
        public string Touser { get; set; }
        public string Subject { get; set; }
        public int? Time { get; set; }
        public short? Cardtype { get; set; }
        public int? Relatedref { get; set; }
        public short? Relatedtyp { get; set; }
        public string Relatedno { get; set; }
        public short? Firmnr { get; set; }
        public byte[] Ldata { get; set; }
    }
}
