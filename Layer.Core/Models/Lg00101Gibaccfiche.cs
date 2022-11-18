using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Gibaccfiche
    {
        public int Logicalref { get; set; }
        public string Ficheno { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? Docdate { get; set; }
        public string Specode { get; set; }
        public string Docode { get; set; }
        public short? Trcode { get; set; }
        public double? Vattotal { get; set; }
        public double? Grosstotal { get; set; }
        public double? Nettotal { get; set; }
        public string Genexp { get; set; }
        public double? Totalactive { get; set; }
        public double? Totalpassive { get; set; }
        public int? Gibdoctypref { get; set; }
        public string Gibdocserialno { get; set; }
        public string Gibdocrowno { get; set; }
        public short? Gibclcardtype { get; set; }
        public int? Gibclcardref { get; set; }
        public string Gibclcardname { get; set; }
        public string Gibclcardsurname { get; set; }
        public double? Gibcreditcardtotal { get; set; }
        public int? Gibcountryref { get; set; }
        public string Gibid { get; set; }
        public short? Gibstatus { get; set; }
        public int? Sourceficheref { get; set; }
        public short? Sourcefichetype { get; set; }
        public int? Periodicitydocref { get; set; }
    }
}
