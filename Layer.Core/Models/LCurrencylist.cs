using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LCurrencylist
    {
        public int Logicalref { get; set; }
        public short? Firmnr { get; set; }
        public short? Curtype { get; set; }
        public string Curcode { get; set; }
        public string Curname { get; set; }
        public short? Coef { get; set; }
        public short? Subdigits { get; set; }
        public string Subname { get; set; }
        public short? Divflag { get; set; }
        public short? Emucurr { get; set; }
        public double? Eurorate { get; set; }
        public short? Sublimit { get; set; }
        public string Cursymbol { get; set; }
        public short? Roundmtd { get; set; }
        public short? Triexch { get; set; }
        public short? Curinuse { get; set; }
        public string Globalid { get; set; }
    }
}
