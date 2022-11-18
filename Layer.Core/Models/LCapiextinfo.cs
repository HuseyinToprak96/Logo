using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LCapiextinfo
    {
        public int Logicalref { get; set; }
        public short? Firmnr { get; set; }
        public short? Typ { get; set; }
        public short? Linenr { get; set; }
        public short? Default { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Subscriber { get; set; }
        public string Senderdef { get; set; }
        public short? Countrytype { get; set; }
    }
}
