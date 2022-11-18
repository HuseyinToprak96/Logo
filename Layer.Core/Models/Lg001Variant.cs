using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Variant
    {
        public int Logicalref { get; set; }
        public int? Itemref { get; set; }
        public short? Cardtype { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public short? Active { get; set; }
        public string Specode { get; set; }
        public string Cyphcode { get; set; }
        public int? Unitsetref { get; set; }
        public int? Qccsetref { get; set; }
        public short? Textinc { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public short? CapiblockCreatedby { get; set; }
        public DateTime? CapiblockCreadeddate { get; set; }
        public short? CapiblockCreatedhour { get; set; }
        public short? CapiblockCreatedmin { get; set; }
        public short? CapiblockCreatedsec { get; set; }
        public short? CapiblockModifiedby { get; set; }
        public DateTime? CapiblockModifieddate { get; set; }
        public short? CapiblockModifiedhour { get; set; }
        public short? CapiblockModifiedmin { get; set; }
        public short? CapiblockModifiedsec { get; set; }
        public short? Usedinperiods { get; set; }
        public string Orglogoid { get; set; }
        public short? Createdin { get; set; }
        public string Guid { get; set; }
        public string Name2 { get; set; }
        public string Specode2 { get; set; }
        public string Specode3 { get; set; }
        public string Specode4 { get; set; }
        public string Specode5 { get; set; }
        public string Stgrpcode { get; set; }
        public string Producercode { get; set; }
        public short? Imageinc { get; set; }
        public string Gtipcode { get; set; }
        public double? Pordamnttolerance { get; set; }
        public double? Sordamnttolerance { get; set; }
        public short? Image2inc { get; set; }
    }
}
