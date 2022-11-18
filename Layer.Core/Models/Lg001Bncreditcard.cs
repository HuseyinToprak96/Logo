using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Bncreditcard
    {
        public int Logicalref { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Specode { get; set; }
        public string Cyphcode { get; set; }
        public short? Crcardtype { get; set; }
        public short? Credittype { get; set; }
        public short? Crcalctype { get; set; }
        public string Gksno { get; set; }
        public DateTime? Begdate { get; set; }
        public DateTime? Enddate { get; set; }
        public short? Trcurr { get; set; }
        public double? Trtotal { get; set; }
        public double? Trratecr { get; set; }
        public double? Trrateacc { get; set; }
        public double? Reportrate { get; set; }
        public int? Bncraccref { get; set; }
        public int? Bncrref { get; set; }
        public int? Bnaccref { get; set; }
        public int? Bnref { get; set; }
        public int? Repayplanref { get; set; }
        public double? Intrate { get; set; }
        public double? Inttotal { get; set; }
        public double? Bsmvrate { get; set; }
        public double? Bsmvtotal { get; set; }
        public double? Kkdfrate { get; set; }
        public double? Kkdftotal { get; set; }
        public double? Commtotal { get; set; }
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
        public short? Branch { get; set; }
        public short? Duedate { get; set; }
        public short? Reversepayment { get; set; }
        public int? Projectref { get; set; }
        public short? Createbnfiche { get; set; }
        public DateTime? Paybegdate { get; set; }
        public string Guid { get; set; }
        public short? Crestatus { get; set; }
        public short? Ppiasdebt { get; set; }
        public DateTime? Structdate { get; set; }
        public short? Periodendpay { get; set; }
        public int? Parentref { get; set; }
        public short? Valorcalc { get; set; }
    }
}
