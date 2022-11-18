using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Workstat
    {
        public int Logicalref { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Specode { get; set; }
        public string Cyphcode { get; set; }
        public short? Factorydivnr { get; set; }
        public short? Factorynr { get; set; }
        public int? Calendarref { get; set; }
        public short? Approved { get; set; }
        public double? Operationtime { get; set; }
        public double? Hourlystdcost { get; set; }
        public double? Hourlystdrpcost { get; set; }
        public int? Accountref { get; set; }
        public int? Centerref { get; set; }
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
        public short? Imageinc { get; set; }
        public int? Wfstatus { get; set; }
        public short? Ininvennr { get; set; }
        public short? Outinvennr { get; set; }
        public int? Shftgrpref { get; set; }
        public int? Hourdiffaccref { get; set; }
        public int? Hourdiffcenter { get; set; }
        public int? Paydiffaccref { get; set; }
        public int? Paydiffcenter { get; set; }
        public int? Projectref { get; set; }
        public string Guid { get; set; }
        public short? Cardtype { get; set; }
    }
}
