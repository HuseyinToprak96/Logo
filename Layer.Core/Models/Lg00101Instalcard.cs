using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg00101Instalcard
    {
        public int Logicalref { get; set; }
        public string Instalno { get; set; }
        public short? Fichetype { get; set; }
        public int? Ficheref { get; set; }
        public int? Clientref { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? Duedate { get; set; }
        public string Specode { get; set; }
        public string Cyphcode { get; set; }
        public string Serino { get; set; }
        public string Guarantor1 { get; set; }
        public string Guarantor2 { get; set; }
        public double? Stamp { get; set; }
        public short? Trcurr { get; set; }
        public short? Transfer { get; set; }
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
        public short? Textinc { get; set; }
        public short? Printcnt { get; set; }
        public double? Return { get; set; }
        public short? Devir { get; set; }
        public string Guid { get; set; }
    }
}
