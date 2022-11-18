using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Responsehistory
    {
        public int Logicalref { get; set; }
        public short? Doctype { get; set; }
        public int? Docref { get; set; }
        public DateTime? Date { get; set; }
        public int? Time { get; set; }
        public short? Estatus { get; set; }
        public short? Responsecode { get; set; }
        public short? Responsestatus { get; set; }
        public string Responsedesc { get; set; }
    }
}
