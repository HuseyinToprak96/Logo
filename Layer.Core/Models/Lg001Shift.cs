﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Shift
    {
        public int Logicalref { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public short? Active { get; set; }
        public string Specode { get; set; }
        public string Cyphcode { get; set; }
        public int? Siteid { get; set; }
        public int? Orglogicref { get; set; }
        public short? CapiblockCreadedby { get; set; }
        public DateTime? CapiblockCreadeddate { get; set; }
        public short? CapiblockCreatedhour { get; set; }
        public short? CapiblockCreatedmin { get; set; }
        public short? CapiblockCreatedsec { get; set; }
        public short? CapiblockModifiedby { get; set; }
        public DateTime? CapiblockModifieddate { get; set; }
        public short? CapiblockModifiedhour { get; set; }
        public short? CapiblockModifiedmin { get; set; }
        public short? CapiblockModifiedsec { get; set; }
        public short? Textinc { get; set; }
        public short? Recstatus { get; set; }
        public double? Costfactor { get; set; }
        public short? Wholeday { get; set; }
        public string Guid { get; set; }
        public short? Cardtype { get; set; }
    }
}