using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Tsksheln
    {
        public int Logicalref { get; set; }
        public short? Tslevel { get; set; }
        public string Tsprocessname { get; set; }
        public int? Tsprocessid { get; set; }
        public string Tsparams { get; set; }
        public short? Tswaittime { get; set; }
        public short? Tsbeginalert { get; set; }
        public short? Tsendalert { get; set; }
        public short? Linenr { get; set; }
        public int? Taskref { get; set; }
        public string Oldtask { get; set; }
        public string Approxtime { get; set; }
    }
}
