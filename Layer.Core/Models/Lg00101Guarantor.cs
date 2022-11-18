using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Guarantor
    {
        public int Logicalref { get; set; }
        public short? Fichetype { get; set; }
        public int? Ficheref { get; set; }
        public short? Guarantornr { get; set; }
        public string Gnamesurname { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string District { get; set; }
        public string Town { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Postcode { get; set; }
        public string Telnrs1 { get; set; }
        public string Telnrs2 { get; set; }
        public string Faxnr { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public int? Clientref { get; set; }
        public string Taxnr { get; set; }
        public string Taxoffice { get; set; }
        public string Taxoffcode { get; set; }
        public string Bankbranchs { get; set; }
        public string Bankaccounts { get; set; }
    }
}
