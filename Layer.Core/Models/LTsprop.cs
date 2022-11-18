using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LTsprop
    {
        public int Logicalref { get; set; }
        public string Tsid { get; set; }
        public short? Usecustomdir { get; set; }
        public short? Usereportname { get; set; }
        public string Customdir { get; set; }
        public string Reportname { get; set; }
        public short? Firmnr { get; set; }
        public short? Usernr { get; set; }
    }
}
