using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Processlog
    {
        public int Logicalref { get; set; }
        public DateTime? Currentdate { get; set; }
        public int? Currenttime { get; set; }
        public short? Datatype { get; set; }
        public short? Genexp { get; set; }
        public short? Action { get; set; }
        public short? Maindoc { get; set; }
        public int? Mainref { get; set; }
        public string Messsagestr { get; set; }
        public string Detailstr { get; set; }
    }
}
