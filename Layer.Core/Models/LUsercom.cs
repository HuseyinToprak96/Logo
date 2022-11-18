using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LUsercom
    {
        public int Logicalref { get; set; }
        public short? Senderusernr { get; set; }
        public short? Receiverusernr { get; set; }
        public short? Comtype { get; set; }
        public short? Status { get; set; }
        public string Requestdate { get; set; }
        public string Startdate { get; set; }
        public string Confirmdate { get; set; }
        public string Info { get; set; }
    }
}
