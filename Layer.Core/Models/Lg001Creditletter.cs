using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Creditletter
    {
        public int Logicalref { get; set; }
        public short? Typ { get; set; }
        public string Letternr { get; set; }
        public DateTime? Issuedate { get; set; }
        public DateTime? Duedate { get; set; }
        public DateTime? Docdeliverydate { get; set; }
        public DateTime? Policydue { get; set; }
        public string Specode { get; set; }
        public string Cyphcode { get; set; }
        public string Explain { get; set; }
        public int? Eximficheref { get; set; }
        public short? Currencytype { get; set; }
        public double? Currencyrate { get; set; }
        public double? Currtotal { get; set; }
        public double? Reportrate { get; set; }
        public double? Reportnet { get; set; }
        public double? Total { get; set; }
        public short? Sendltdflag { get; set; }
        public short? Transferflag { get; set; }
        public short? Returnflag { get; set; }
        public short? Confirmflag { get; set; }
        public short? Insurancerange { get; set; }
        public short? Usagetype { get; set; }
        public int? Bankref { get; set; }
        public int? Bnaccref { get; set; }
        public string Referencenr { get; set; }
        public string Infobankname { get; set; }
        public string Infobankaddr1 { get; set; }
        public string Infobankaddr2 { get; set; }
        public string Confbankname { get; set; }
        public string Confbankaddr1 { get; set; }
        public string Confbankaddr2 { get; set; }
        public short? Paymenttype { get; set; }
        public string Ramsbankname { get; set; }
        public string Ramsbankaddr1 { get; set; }
        public string Ramsbankaddr2 { get; set; }
        public short? Expinflag { get; set; }
        public short? Expoutflag { get; set; }
        public short? Infobankcommflag { get; set; }
        public double? Commastbank { get; set; }
        public double? Cominfobank { get; set; }
        public string Deliveryplace { get; set; }
        public DateTime? Deliverydate { get; set; }
        public string Deliveryaddr { get; set; }
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
        public int? Creditref { get; set; }
        public double? Credittotal { get; set; }
        public double? Creditcrate { get; set; }
        public string Frgtypcod { get; set; }
        public short? Status { get; set; }
        public short? Revolving { get; set; }
        public short? Backtoback { get; set; }
        public short? Standby { get; set; }
        public short? Redclause { get; set; }
        public short? Greenclause { get; set; }
        public short? Textinc { get; set; }
        public string Guid { get; set; }
        public DateTime? Installdate { get; set; }
        public DateTime? Lastinstalldate { get; set; }
        public int? Clientref { get; set; }
    }
}
