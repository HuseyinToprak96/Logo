using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Okcinfo
    {
        public int Logicalref { get; set; }
        public int? Invoiceref { get; set; }
        public short? Fichetype { get; set; }
        public string Fichenumber { get; set; }
        public DateTime? Date { get; set; }
        public int? Time { get; set; }
        public string Serialnumber { get; set; }
        public string Znumber { get; set; }
        public string Fixedvalue { get; set; }
        public short? Linenr { get; set; }
        public int? Stfref { get; set; }
    }
}
