using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Dataexchhistory
    {
        public int Logicalref { get; set; }
        public short? Doctype { get; set; }
        public int? Docref { get; set; }
        public string Logoid { get; set; }
        public short? Savetype { get; set; }
        public short? Optype { get; set; }
        public string Transid { get; set; }
        public short? Transtype { get; set; }
        public DateTime? Createddate { get; set; }
        public int? Createdtime { get; set; }
        public string Description { get; set; }
        public int? Autopackref { get; set; }
        public DateTime? Docmoddate { get; set; }
        public short? Docmodhour { get; set; }
        public short? Docmodmin { get; set; }
        public short? Docmodsec { get; set; }
        public string Recvpackid { get; set; }
        public DateTime? Docdate { get; set; }
    }
}
