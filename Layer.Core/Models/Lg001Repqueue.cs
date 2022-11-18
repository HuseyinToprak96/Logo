using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Repqueue
    {
        public int Logicalref { get; set; }
        public int? Taskid { get; set; }
        public string Queueid { get; set; }
        public short? Devtype { get; set; }
        public short? Gridtype { get; set; }
        public int? Custdsgref { get; set; }
        public int? Filterref { get; set; }
        public DateTime? Queuedate { get; set; }
        public int? Queuetime { get; set; }
        public short? Status { get; set; }
        public short? Result { get; set; }
    }
}
