using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LGibsubrectype
    {
        public int Logicalref { get; set; }
        public string Gibcode { get; set; }
        public string Gibdef { get; set; }
        public short? Fctype { get; set; }
        public string Recgibcode { get; set; }
        public string Gibid { get; set; }
        public string Gibclientid { get; set; }
        public int? Gibrectypref { get; set; }
        public short? Gibupdate { get; set; }
    }
}
