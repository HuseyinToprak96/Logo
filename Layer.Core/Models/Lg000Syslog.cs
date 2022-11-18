using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg000Syslog
    {
        public int Logicalref { get; set; }
        public string Username { get; set; }
        public short? Firmno { get; set; }
        public DateTime? Date { get; set; }
        public short? Second { get; set; }
        public short? Minute { get; set; }
        public short? Hour { get; set; }
        public short? Procs11 { get; set; }
        public short? Procs12 { get; set; }
        public short? Procs13 { get; set; }
        public short? Procs14 { get; set; }
        public short? Procs15 { get; set; }
        public short? Procs21 { get; set; }
        public short? Procs22 { get; set; }
        public short? Procs23 { get; set; }
        public short? Procs24 { get; set; }
        public short? Procs25 { get; set; }
        public short? Procs26 { get; set; }
        public string Msgs1 { get; set; }
        public string Msgs2 { get; set; }
        public short? Branch { get; set; }
        public short? Department { get; set; }
        public string Termcode { get; set; }
        public short? Perno { get; set; }
        public short? Portnr { get; set; }
        public int? Portref { get; set; }
        public string Description { get; set; }
    }
}
