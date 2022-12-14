using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Clfline
    {
        public int Logicalref { get; set; }
        public int? Clientref { get; set; }
        public int? Claccref { get; set; }
        public int? Clcenterref { get; set; }
        public int? Cashcenterref { get; set; }
        public int? Cashaccountref { get; set; }
        public int? Virmanref { get; set; }
        public int? Sourcefref { get; set; }
        public DateTime? Date { get; set; }
        public short? Department { get; set; }
        public short? Branch { get; set; }
        public short? Modulenr { get; set; }
        public short? Trcode { get; set; }
        public short? Linenr { get; set; }
        public string Specode { get; set; }
        public string Cyphcode { get; set; }
        public string Tranno { get; set; }
        public string Docode { get; set; }
        public string Lineexp { get; set; }
        public short? Accounted { get; set; }
        public short? Sign { get; set; }
        public double? Amount { get; set; }
        public short? Trcurr { get; set; }
        public double? Trrate { get; set; }
        public double? Trnet { get; set; }
        public double? Reportrate { get; set; }
        public double? Reportnet { get; set; }
        public int? Extenref { get; set; }
        public int? Paydefref { get; set; }
        public int? Accficheref { get; set; }
        public short? Printcnt { get; set; }
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
        public short? Cancelled { get; set; }
        public short? Trgflag { get; set; }
        public string Tradinggrp { get; set; }
        public short? Lineexctyp { get; set; }
        public short? Onlyonepayline { get; set; }
        public short? Discflag { get; set; }
        public double? Discrate { get; set; }
        public double? Vatrate { get; set; }
        public double? Cashamount { get; set; }
        public int? Discaccref { get; set; }
        public int? Disccenref { get; set; }
        public int? Vatraccref { get; set; }
        public int? Vatrcenref { get; set; }
        public int? Paymentref { get; set; }
        public double? Vatamount { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public double? Infidx { get; set; }
        public int? Poscommaccref { get; set; }
        public int? Poscommcenref { get; set; }
        public int? Pointcommaccref { get; set; }
        public int? Pointcommcenref { get; set; }
        public string Cheqinfo { get; set; }
        public string Creditcno { get; set; }
        public int? Clprjref { get; set; }
        public short? Status { get; set; }
        public int? Eximfileref { get; set; }
        public short? Eximprocnr { get; set; }
        public short? Month { get; set; }
        public short? Year { get; set; }
        public double? Fundsharerat { get; set; }
        public short? Affectcollatrl { get; set; }
        public short? Grpfirmtrans { get; set; }
        public int? Reflvataccref { get; set; }
        public int? Reflvatothaccref { get; set; }
        public short? Affectrisk { get; set; }
        public int? Batchnr { get; set; }
        public int? Approvenr { get; set; }
        public string Batchnum { get; set; }
        public string Approvenum { get; set; }
        public int? Euvatstatus { get; set; }
        public string Orglogoid { get; set; }
        public short? Eximtype { get; set; }
        public short? Eidistflnnr { get; set; }
        public short? Eisrvdsttyp { get; set; }
        public short? Eximdisttyp { get; set; }
        public int? Salesmanref { get; set; }
        public int? Bankaccref { get; set; }
        public int? Bnaccref { get; set; }
        public int? Bncenterref { get; set; }
        public DateTime? Devirprocdate { get; set; }
        public DateTime? Docdate { get; set; }
        public int? Instalref { get; set; }
        public short? Devir { get; set; }
        public int? Devirmodulenr { get; set; }
        public int? Ftime { get; set; }
        public int? Offerref { get; set; }
        public int? Retccfcref { get; set; }
        public int? Emflineref { get; set; }
        public short? Fromexchdiff { get; set; }
        public short? Candeduct { get; set; }
        public short? Deductionpart1 { get; set; }
        public short? Deductionpart2 { get; set; }
        public short? Underdeductlimit { get; set; }
        public double? Vatdeductrate { get; set; }
        public int? Vatdeductaccref { get; set; }
        public int? Vatdeductothaccref { get; set; }
        public int? Vatdeductcenref { get; set; }
        public int? Vatdeductothcenref { get; set; }
        public short? Cantcrededuct { get; set; }
        public string Guid { get; set; }
        public short? Paidincash { get; set; }
        public double? Brutamount { get; set; }
        public double? Netamount { get; set; }
        public double? Brutamounttr { get; set; }
        public double? Netamounttr { get; set; }
        public double? Brutamountrep { get; set; }
        public double? Netamountrep { get; set; }
        public short? Bnlntrcurr { get; set; }
        public double? Bnlntrrate { get; set; }
        public double? Bnlntrnet { get; set; }
        public DateTime? Printdate { get; set; }
        public short? Incdeductamnt { get; set; }
        public short? Affectcost { get; set; }
        public short? Forexim { get; set; }
        public string Eximfilecodeclf { get; set; }
        public string Specode2 { get; set; }
        public string Servreasondef { get; set; }
    }
}
