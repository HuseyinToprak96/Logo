using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Reckeeping
    {
        public int Logicalref { get; set; }
        public DateTime? Begdate { get; set; }
        public DateTime? Enddate { get; set; }
        public short? Purchcrexml { get; set; }
        public short? Purchcreexcel { get; set; }
        public short? Purchcrexprl { get; set; }
        public short? Salescrexml { get; set; }
        public short? Salescreexcel { get; set; }
        public short? Salescrexprl { get; set; }
        public short? Importcrexml { get; set; }
        public short? Importcreexcel { get; set; }
        public short? Importcrexprl { get; set; }
        public short? Exportcrexml { get; set; }
        public short? Exportcreexcel { get; set; }
        public short? Exportcrexprl { get; set; }
        public short? Producecrexml { get; set; }
        public short? Producecreexcel { get; set; }
        public short? Producecrexprl { get; set; }
        public short? Stockcrexml { get; set; }
        public short? Stockcreexcel { get; set; }
        public short? Stockcrexprl { get; set; }
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
    }
}
