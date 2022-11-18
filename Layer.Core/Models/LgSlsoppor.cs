using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LgSlsoppor
    {
        public int Logicalref { get; set; }
        public string Oppno { get; set; }
        public string Description { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? Expecdate { get; set; }
        public DateTime? Closedate { get; set; }
        public string Specode { get; set; }
        public string Cyphcode { get; set; }
        public int? Salesmanref { get; set; }
        public int? Cstvndref { get; set; }
        public int? Contactref { get; set; }
        public double? Expecrev { get; set; }
        public short? Revcurr { get; set; }
        public double? Revrate { get; set; }
        public double? Revcamount { get; set; }
        public double? Succprob { get; set; }
        public short? Stage { get; set; }
        public string Comments { get; set; }
        public int? Siteid { get; set; }
        public int? Orglogicref { get; set; }
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
        public short? Recstatus { get; set; }
        public short? Textinc { get; set; }
        public double? Reportrate { get; set; }
        public double? Reportrev { get; set; }
        public string Guid { get; set; }
    }
}
