using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Distvehicle
    {
        public int Logicalref { get; set; }
        public string Code { get; set; }
        public string Definition { get; set; }
        public string Specode { get; set; }
        public string Cyphcode { get; set; }
        public string Plaque { get; set; }
        public double? Width { get; set; }
        public double? Length { get; set; }
        public double? Height { get; set; }
        public double? Area { get; set; }
        public double? Volume { get; set; }
        public double? Weight { get; set; }
        public int? Widthref { get; set; }
        public int? Lengthref { get; set; }
        public int? Heightref { get; set; }
        public int? Arearef { get; set; }
        public int? Volumeref { get; set; }
        public int? Weightref { get; set; }
        public double? Score { get; set; }
        public string User1 { get; set; }
        public string User2 { get; set; }
        public short? Active { get; set; }
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
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public short? Textinc { get; set; }
        public int? Wfstatus { get; set; }
        public double? Unitcost { get; set; }
        public string Unitcostcode { get; set; }
        public double? Waitingprice { get; set; }
        public double? Fixedprice { get; set; }
        public double? Minimalprice { get; set; }
        public string Itmspecode { get; set; }
        public string Itmspecode2 { get; set; }
        public string Itmspecode3 { get; set; }
        public string Itmspecode4 { get; set; }
        public string Itmspecode5 { get; set; }
    }
}
