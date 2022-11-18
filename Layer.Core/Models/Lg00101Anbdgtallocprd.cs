using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Anbdgtallocprd
    {
        public int Logicalref { get; set; }
        public DateTime? Date { get; set; }
        public int? Ftime { get; set; }
        public short? Status { get; set; }
        public int? Srcbdgtref { get; set; }
        public int? Dstbdgtref { get; set; }
        public int? Bdallocfcref { get; set; }
        public int? Bdalloclnref { get; set; }
        public int? Srcaccref { get; set; }
        public int? Srccrsaccref { get; set; }
        public int? Srccrsraccref { get; set; }
        public int? Dstaccref { get; set; }
        public int? Dstcrsaccref { get; set; }
        public int? Dstcrsraccref { get; set; }
        public short? Lineno { get; set; }
        public short? Prdno { get; set; }
        public DateTime? Prdbegdate { get; set; }
        public DateTime? Prdenddate { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
        public int? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public string Orglogoid { get; set; }
    }
}
