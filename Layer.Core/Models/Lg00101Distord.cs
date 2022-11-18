using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Distord
    {
        public int Logicalref { get; set; }
        public string Ficheno { get; set; }
        public DateTime? Date { get; set; }
        public string Specode { get; set; }
        public string Cyphcode { get; set; }
        public int? Vehicleref { get; set; }
        public int? Routref { get; set; }
        public short? Status { get; set; }
        public short? Maxclientlimit { get; set; }
        public double? Loadrate { get; set; }
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
        public int? Wfstatus { get; set; }
        public int? Salesmanref { get; set; }
        public DateTime? Godate { get; set; }
        public DateTime? Returndate { get; set; }
        public short? Ordfcwithpay { get; set; }
        public short? Affectcollatrl { get; set; }
        public short? Affectrisk { get; set; }
        public short? Branch { get; set; }
        public short? Department { get; set; }
        public short? Factory { get; set; }
        public short? Printcnt { get; set; }
        public string Guid { get; set; }
        public DateTime? Printdate { get; set; }
    }
}
