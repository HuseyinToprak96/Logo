using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Gibaccficheln
    {
        public int Logicalref { get; set; }
        public int? Ficheref { get; set; }
        public int? Accref { get; set; }
        public int? Vataccref { get; set; }
        public short? Trcode { get; set; }
        public short? Vatinclude { get; set; }
        public short? Linenr { get; set; }
        public short? Sign { get; set; }
        public double? Total { get; set; }
        public double? Linenet { get; set; }
        public double? Vatrate { get; set; }
        public double? Vattotal { get; set; }
        public string Lineexp { get; set; }
        public double? Vatcalcdiff { get; set; }
        public int? Giblinetypref { get; set; }
        public int? Gibrectypref { get; set; }
        public int? Gibsubrectypref { get; set; }
        public int? Gibincmtaxref { get; set; }
        public double? Gibincmtaxrate { get; set; }
        public double? Gibincmtaxtotal { get; set; }
        public int? Gibexpsalesref { get; set; }
        public int? Gibpartdeductref { get; set; }
        public double? Gibpartdeductrate { get; set; }
        public double? Gibpartdeducttotal { get; set; }
        public int? Gibotheroprref { get; set; }
        public int? Gibpartexceptref { get; set; }
        public int? Gibfullexceptref { get; set; }
        public short? Novat { get; set; }
        public int? Gibpaymenttypref { get; set; }
        public double? Gibcustvatmatrah { get; set; }
        public double? Gibcuststocktotal { get; set; }
        public double? Gibcustextpayment { get; set; }
        public string Gibid { get; set; }
        public int? Faregref { get; set; }
        public int? Gibfaregexptypref { get; set; }
        public string Gibcostid { get; set; }
        public double? Gibsalesquantity { get; set; }
        public int? Gibfaregsalesref { get; set; }
        public short? Periodicity { get; set; }
        public string Parentperctygibid { get; set; }
    }
}
