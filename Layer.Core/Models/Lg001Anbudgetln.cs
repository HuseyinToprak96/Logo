using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Anbudgetln
    {
        public int Logicalref { get; set; }
        public int? Bdgtref { get; set; }
        public int? Bdgtprdref { get; set; }
        public string Specode { get; set; }
        public string Lineexp { get; set; }
        public short? Lineno { get; set; }
        public int? Accref { get; set; }
        public int? Crsaccref { get; set; }
        public int? Crsraccref { get; set; }
        public string Acccorpcode1 { get; set; }
        public string Acccorpcode2 { get; set; }
        public string Acccorpcode3 { get; set; }
        public string Acccorpcode4 { get; set; }
        public string Accfunccode1 { get; set; }
        public string Accfunccode2 { get; set; }
        public string Accfunccode3 { get; set; }
        public string Accfunccode4 { get; set; }
        public string Accfincode { get; set; }
        public string Accecocode1 { get; set; }
        public string Accecocode2 { get; set; }
        public string Accecocode3 { get; set; }
        public string Accecocode4 { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
        public short? Branch { get; set; }
        public short? Department { get; set; }
        public int? Bdgtrevfcref { get; set; }
        public short? Bdgtrevno { get; set; }
        public int? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public string Orglogoid { get; set; }
    }
}
