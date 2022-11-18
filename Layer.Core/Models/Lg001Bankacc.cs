using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Bankacc
    {
        public int Logicalref { get; set; }
        public short? Cardtype { get; set; }
        public string Code { get; set; }
        public string Definition { get; set; }
        public string Specode { get; set; }
        public string Cyphcode { get; set; }
        public int? Bankref { get; set; }
        public double? Checkmargin { get; set; }
        public double? Notemargin { get; set; }
        public double? Checklimit { get; set; }
        public double? Notelimit { get; set; }
        public double? Custinterest { get; set; }
        public double? Skinterest { get; set; }
        public double? Ckinterest { get; set; }
        public double? Stopajper { get; set; }
        public double? Fonper { get; set; }
        public short? Currency { get; set; }
        public int? Extenref { get; set; }
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
        public short? Active { get; set; }
        public string Accountno { get; set; }
        public short? Textinc { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public int? Wfstatus { get; set; }
        public short? Kkusage { get; set; }
        public double? Collatrllimit { get; set; }
        public short? Curratetype { get; set; }
        public double? Wthcltrlinterest { get; set; }
        public double? Wthcltrllimit { get; set; }
        public short? Usedinperiods { get; set; }
        public string Iban { get; set; }
        public short? Cutoffday { get; set; }
        public short? Lastpaymentday { get; set; }
        public double? Creditcardlimit { get; set; }
        public string Creditcardno { get; set; }
        public string Glbbankbranch { get; set; }
        public int? Defbnaccref { get; set; }
        public string Guid { get; set; }
        public string Batchnum { get; set; }
        public string Posterminalnum { get; set; }
        public int? Defksref { get; set; }
    }
}
