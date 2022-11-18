using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Clcollatrlrisk
    {
        public int Logicalref { get; set; }
        public int? Clcardref { get; set; }
        public short? Risktype { get; set; }
        public short? Riskover { get; set; }
        public short? Ordriskover { get; set; }
        public short? Despriskover { get; set; }
        public short? Usereprisk { get; set; }
        public double? Pcollatrltotal { get; set; }
        public double? Reppcollatrltotal { get; set; }
        public double? Scollatrltotal { get; set; }
        public double? Repscollatrltotal { get; set; }
        public double? Risktotal { get; set; }
        public double? Reprisktotal { get; set; }
        public double? Desprisktotal { get; set; }
        public double? Repdesprisktotal { get; set; }
        public double? Risklimit { get; set; }
        public double? Reprisklimit { get; set; }
        public double? Riskbalanced { get; set; }
        public double? Repriskbalanced { get; set; }
        public double? Ordrisktotal { get; set; }
        public double? Repordrisktotal { get; set; }
        public double? Ordrisktotalsugg { get; set; }
        public double? Repordrisktotalsugg { get; set; }
        public double? Riskfactor { get; set; }
        public short? Separatecsrisktotal { get; set; }
        public short? Csriskover { get; set; }
        public double? Csrisktotal { get; set; }
        public double? Repcsrisktotal { get; set; }
    }
}
