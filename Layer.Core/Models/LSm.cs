using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LSm
    {
        public int Logicalref { get; set; }
        public string Code { get; set; }
        public DateTime? Begdate { get; set; }
        public int? Begtime { get; set; }
        public short? Status { get; set; }
        public short? Usernr { get; set; }
        public string Definition { get; set; }
        public short? Repeattype { get; set; }
        public DateTime? Repdate { get; set; }
        public int? Reptime { get; set; }
        public short? Repmonth { get; set; }
        public short? Repday36 { get; set; }
        public short? Cardtype { get; set; }
        public short? Missedsmscount { get; set; }
        public short? Smsservice { get; set; }
        public short? Sendedsmscount { get; set; }
        public string Smsfirms { get; set; }
        public string Suppliercode { get; set; }
        public string Smsusers { get; set; }
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
        public short? Smslock { get; set; }
        public short? Issms { get; set; }
        public DateTime? Lastsmsday { get; set; }
        public string Grpcode { get; set; }
    }
}
