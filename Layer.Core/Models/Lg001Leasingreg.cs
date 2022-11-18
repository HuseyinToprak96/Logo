using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Leasingreg
    {
        public int Logicalref { get; set; }
        public string Regnr { get; set; }
        public string Description { get; set; }
        public DateTime? Begdate { get; set; }
        public DateTime? Enddate { get; set; }
        public string Specode { get; set; }
        public string Cyphcode { get; set; }
        public string Docode { get; set; }
        public short? Branch { get; set; }
        public short? Department { get; set; }
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
        public short? Printcnt { get; set; }
        public short? Accounted { get; set; }
        public int? Accficheref { get; set; }
        public int? Rightsaccref { get; set; }
        public int? Sdebtcostaccref { get; set; }
        public int? Ldebtcostaccref { get; set; }
        public int? Sdebtaccref { get; set; }
        public int? Ldebtaccref { get; set; }
        public int? Rightscntrref { get; set; }
        public int? Sdebtcostcntrref { get; set; }
        public int? Ldebtcostcntrref { get; set; }
        public int? Sdebtcntrref { get; set; }
        public int? Ldebtcntrref { get; set; }
        public DateTime? Printdate { get; set; }
        public short? Renttype { get; set; }
        public int? Clientref { get; set; }
        public int? Intaccref { get; set; }
        public int? Depaccref { get; set; }
        public int? Intcntrref { get; set; }
        public int? Depcntrref { get; set; }
    }
}
