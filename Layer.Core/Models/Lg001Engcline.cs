using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Engcline
    {
        public int Logicalref { get; set; }
        public string Ficheno { get; set; }
        public DateTime? Date { get; set; }
        public string Specode { get; set; }
        public string Cyphcode { get; set; }
        public short? Appstatus { get; set; }
        public string Reason { get; set; }
        public int? Bommasterref { get; set; }
        public int? Oldrevref { get; set; }
        public int? Newrevref { get; set; }
        public short? Method { get; set; }
        public DateTime? Datefrom { get; set; }
        public string Serilotfrom { get; set; }
        public int? Bomlineref { get; set; }
        public int? Itemref { get; set; }
        public DateTime? Validdate { get; set; }
        public short? Validstatus { get; set; }
        public short? Approved { get; set; }
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
        public string Guid { get; set; }
        public int? Clientref { get; set; }
    }
}
