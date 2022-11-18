using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Occupation
    {
        public int Logicalref { get; set; }
        public int? Prodordref { get; set; }
        public int? Displineref { get; set; }
        public short? Occstatus { get; set; }
        public short? Occtype { get; set; }
        public int? Laborreqref { get; set; }
        public int? Empref { get; set; }
        public int? Toolreqref { get; set; }
        public int? Toolref { get; set; }
        public double? Amount { get; set; }
        public DateTime? Begdate { get; set; }
        public int? Begtime { get; set; }
        public DateTime? Enddate { get; set; }
        public int? Endtime { get; set; }
        public double? Duration { get; set; }
        public short? Wizentry { get; set; }
        public double? Costfactor { get; set; }
        public double? Opduration { get; set; }
        public double? Opamount { get; set; }
        public int? Setuptime { get; set; }
        public double? Runbatch { get; set; }
        public int? Runtime { get; set; }
        public double? Movebatch { get; set; }
        public int? Movetime { get; set; }
        public short? Calctyp { get; set; }
        public double? Waitbatch { get; set; }
        public int? Waittime { get; set; }
    }
}
