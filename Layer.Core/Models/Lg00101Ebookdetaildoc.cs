using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Ebookdetaildoc
    {
        public int Logicalref { get; set; }
        public int? Emficheref { get; set; }
        public short? Documenttype { get; set; }
        public string Explain { get; set; }
        public string Documentnr { get; set; }
        public DateTime? Documentdate { get; set; }
        public string Paytype { get; set; }
        public short? Undocumented { get; set; }
        public short? Nopayment { get; set; }
        public int? Emflineref { get; set; }
        public short? Modulenr { get; set; }
        public int? Sourcefref { get; set; }
    }
}
