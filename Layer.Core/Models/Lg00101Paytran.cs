using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Paytran
    {
        public int Logicalref { get; set; }
        public int? Cardref { get; set; }
        public DateTime? Date { get; set; }
        public short? Modulenr { get; set; }
        public short? Sign { get; set; }
        public int? Ficheref { get; set; }
        public int? Fichelineref { get; set; }
        public short? Trcode { get; set; }
        public double? Total { get; set; }
        public double? Paid { get; set; }
        public double? Earlyintrate { get; set; }
        public double? Latelyintrate { get; set; }
        public int? Crossref { get; set; }
        public short? Paidincash { get; set; }
        public short? Cancelled { get; set; }
        public DateTime? Procdate { get; set; }
        public short? Trcurr { get; set; }
        public double? Trrate { get; set; }
        public double? Reportrate { get; set; }
        public short? Modified { get; set; }
        public short? Remindlev { get; set; }
        public short? Remindsent { get; set; }
        public short? Crosscurr { get; set; }
        public double? Crosstotal { get; set; }
        public short? Discflag { get; set; }
        public short? Siteid { get; set; }
        public int? Orglogicref { get; set; }
        public int? Wfstatus { get; set; }
        public double? Closingrate { get; set; }
        public DateTime? Discduedate { get; set; }
        public short? Opstat { get; set; }
        public short? Recstatus { get; set; }
        public double? Infidx { get; set; }
        public short? Payno { get; set; }
        public double? Delaytotal { get; set; }
        public int? Lastsendremlev { get; set; }
        public short? Pointtrans { get; set; }
        public DateTime? Bankpaydate { get; set; }
        public double? Poscomsn { get; set; }
        public double? Pointcomsn { get; set; }
        public int? Bankaccref { get; set; }
        public short? Paymenttype { get; set; }
        public int? Cashaccref { get; set; }
        public double? Trnet { get; set; }
        public int? Repayplanref { get; set; }
        public double? Duediffcomsn { get; set; }
        public short? Calctype { get; set; }
        public double? Nettotal { get; set; }
        public short? Repyplnapplied { get; set; }
        public short? Paytrcurr { get; set; }
        public double? Paytrrate { get; set; }
        public double? Paytrnet { get; set; }
        public short? Bntrcreated { get; set; }
        public int? Bnfchref { get; set; }
        public int? Bnflnref { get; set; }
        public short? Instaltype { get; set; }
        public int? Instalref { get; set; }
        public int? Maininstalref { get; set; }
        public string Orglogoid { get; set; }
        public int? Stlineref { get; set; }
        public string Specode { get; set; }
        public string Creditcardnum { get; set; }
        public DateTime? Valbegdate { get; set; }
        public string Retrefno { get; set; }
        public string Docode { get; set; }
        public string Batchnum { get; set; }
        public string Approvenum { get; set; }
        public string Posterminalnum { get; set; }
        public short? Cldiffinv { get; set; }
        public string Lineexp { get; set; }
        public DateTime? Devirprocdate { get; set; }
        public short? Devir { get; set; }
        public int? Devircardref { get; set; }
        public string Globalcode { get; set; }
        public string Clbnaccountno { get; set; }
        public DateTime? Matchdate { get; set; }
        public short? Devirbranch { get; set; }
        public short? Devirdepartment { get; set; }
        public int? Devirficheref { get; set; }
        public int? Devirlineref { get; set; }
        public double? Currdiffrate { get; set; }
        public short? Currdiffclosed { get; set; }
        public int? Currdiffclsref { get; set; }
        public short? Vatflag { get; set; }
    }
}
