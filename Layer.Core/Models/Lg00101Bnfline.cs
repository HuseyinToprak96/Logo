using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Bnfline
    {
        public int Logicalref { get; set; }
        public int? Bankref { get; set; }
        public int? Bnaccref { get; set; }
        public int? Clientref { get; set; }
        public int? Accountref { get; set; }
        public int? Centerref { get; set; }
        public int? Bnaccountref { get; set; }
        public int? Bncenterref { get; set; }
        public int? Virmanref { get; set; }
        public int? Sourcefref { get; set; }
        public short? Transtype { get; set; }
        public DateTime? Date { get; set; }
        public short? Department { get; set; }
        public short? Branch { get; set; }
        public short? Sign { get; set; }
        public short? Trcode { get; set; }
        public short? Modulenr { get; set; }
        public short? Linenr { get; set; }
        public string Specode { get; set; }
        public string Cyphcode { get; set; }
        public string Tranno { get; set; }
        public string Docode { get; set; }
        public string Lineexp { get; set; }
        public short? Accounted { get; set; }
        public short? Trcurr { get; set; }
        public double? Amount { get; set; }
        public double? Trrate { get; set; }
        public double? Trnet { get; set; }
        public double? Reportrate { get; set; }
        public double? Reportnet { get; set; }
        public int? Extenref { get; set; }
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
        public string Clbnbranchno { get; set; }
        public string Clbnaccountno { get; set; }
        public string Bntrackingno { get; set; }
        public short? Trnstate { get; set; }
        public string Tradinggrp { get; set; }
        public short? Lineexctyp { get; set; }
        public short? Discflag { get; set; }
        public double? Discrate { get; set; }
        public double? Vatrate { get; set; }
        public double? Arcloseamount { get; set; }
        public int? Discaccref { get; set; }
        public int? Disccenref { get; set; }
        public int? Vatraccref { get; set; }
        public int? Vatrcenref { get; set; }
        public int? Paymentref { get; set; }
        public short? Bankproctype { get; set; }
        public short? Bankproccode { get; set; }
        public DateTime? Transduedate { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public short? Opstat { get; set; }
        public double? Infidx { get; set; }
        public string Eximficheno { get; set; }
        public short? Bntranvatinc { get; set; }
        public double? Bntranvatrat { get; set; }
        public int? Bntranvataccref { get; set; }
        public int? Bntranvatcenref { get; set; }
        public double? Bntranvattot { get; set; }
        public string Cheqinfo { get; set; }
        public int? Eximinforef { get; set; }
        public double? Eximinfopar { get; set; }
        public int? Excreref { get; set; }
        public short? Crcardwzd { get; set; }
        public short? Comstype { get; set; }
        public int? Provisionref { get; set; }
        public short? Trangrplineno { get; set; }
        public int? Projectref { get; set; }
        public DateTime? Trangrpdate { get; set; }
        public string Trangrpno { get; set; }
        public string Bankrefnr { get; set; }
        public string Customdocnr { get; set; }
        public int? Dablnref { get; set; }
        public int? Transref { get; set; }
        public short? Affectcollatrl { get; set; }
        public int? Collatrollref { get; set; }
        public int? Collattrnref { get; set; }
        public int? Collatcardref { get; set; }
        public short? Grpfirmtrans { get; set; }
        public short? Affectrisk { get; set; }
        public short? Bncrsource { get; set; }
        public int? Bncrref { get; set; }
        public short? Bncrlntype { get; set; }
        public string Orglogoid { get; set; }
        public int? Cstransref { get; set; }
        public short? Reflected { get; set; }
        public int? Reflaccficheref { get; set; }
        public string Iban { get; set; }
        public string Bankbranchs { get; set; }
        public string Bankaccounts { get; set; }
        public short? Costowner { get; set; }
        public string Costaccount { get; set; }
        public int? Costaccref { get; set; }
        public double? Costtot { get; set; }
        public double? Bsmvtot { get; set; }
        public int? Bntrcostaccref { get; set; }
        public int? Bntrcostcenref { get; set; }
        public int? Bnbsmvaccref { get; set; }
        public int? Bnbsmvcenref { get; set; }
        public double? Repcosttot { get; set; }
        public double? Repbsmvtot { get; set; }
        public double? Trcosttot { get; set; }
        public double? Trbsmvtot { get; set; }
        public short? Cltrcurr { get; set; }
        public double? Cltrrate { get; set; }
        public double? Cltrnet { get; set; }
        public int? Salesmanref { get; set; }
        public int? Bnintaccref { get; set; }
        public int? Bnintcenref { get; set; }
        public int? Bnkkdfaccref { get; set; }
        public int? Bnkkdfcenref { get; set; }
        public int? Bnfincostaccref { get; set; }
        public int? Bnfincostcenref { get; set; }
        public short? Dbs { get; set; }
        public int? Clflineref { get; set; }
        public int? Kkblockedref { get; set; }
        public int? Clficheref { get; set; }
        public int? Creletterref { get; set; }
        public int? Offerref { get; set; }
        public short? Bntrancosttotinc { get; set; }
        public int? Crcardfcref { get; set; }
        public int? Ccpaytrref { get; set; }
        public int? Emflineref { get; set; }
        public string Guid { get; set; }
        public DateTime? Docdate { get; set; }
        public int? Bntrcostaccref2 { get; set; }
        public double? Bncrtrrate { get; set; }
        public DateTime? Printdate { get; set; }
        public int? Processaccref { get; set; }
        public int? Processcenref { get; set; }
        public string Custtitle { get; set; }
        public string Bngpaddr { get; set; }
        public string Bngpplate { get; set; }
        public int? Bngptaxaccref { get; set; }
        public int? Bngptaxcenref { get; set; }
        public int? Bngpfundaccref { get; set; }
        public int? Bngpfundcenref { get; set; }
        public short? Bngpoptype { get; set; }
        public double? Bngpincometaxrat { get; set; }
        public double? Bngpfundsharerat { get; set; }
        public string Typecode { get; set; }
        public double? Fundquantity { get; set; }
        public short? Status { get; set; }
        public int? Time { get; set; }
        public short? Paytype { get; set; }
    }
}
